using System.Diagnostics;
using EfCore.Shared;
using EFCore.Shared;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.EF;

static async Task Measure(string name, Func<Task> act)
{
    var sw = Stopwatch.StartNew();
    await act();
    sw.Stop();
    Console.WriteLine($"{name,-26} | {sw.ElapsedMilliseconds,5} ms");
}
// Helper para medir código síncrono
static void MeasureSync(string name, Action act)
{
    var sw = Stopwatch.StartNew();
    act();
    sw.Stop();
    Console.WriteLine($"{name,-26} | {sw.ElapsedMilliseconds,5} ms");
}

var opts = Db.Sqlite("eflab.db");
using var db = new AppDbContext(opts);
await DataSeeder.EnsureSeedAsync(db);

// 1) Baseline (tracking + includes)
await Measure("Baseline tracking + Include", async () =>
{
    var list = await db.Orders
        .Include(o => o.Customer)
        .Include(o => o.Items).ThenInclude(i => i.Product)
        .Take(500)
        .ToListAsync();
    Console.WriteLine($"Fetched: {list.Count}");
});

// 2) AsNoTracking (mismos includes)
await Measure("AsNoTracking", async () =>
{
    var list = await db.Orders
        .AsNoTracking()
        .Include(o => o.Customer)
        .Include(o => o.Items).ThenInclude(i => i.Product)
        .Take(500)
        .ToListAsync();
    Console.WriteLine($"Fetched: {list.Count}");
});



// 3) Proyección -> DTO (selección explícita)
await Measure("Projection -> DTO", async () =>
{
    var list = await db.Orders
        .AsNoTracking()
        .Select(o => new OrderDto(
            o.Id,
            o.Customer.Name,
            o.Items.Count,
            o.Items.Sum(i => i.Quantity * i.UnitPrice)
        ))
        .Take(500)
        .ToListAsync();
    Console.WriteLine($"Fetched DTOs: {list.Count}");
});

// 4) AsSplitQuery + Include (evitar cartesianas)
await Measure("AsSplitQuery + Include", async () =>
{
    var list = await db.Orders
        .AsNoTracking()
        .AsSplitQuery()
        .Include(o => o.Customer)
        .Include(o => o.Items).ThenInclude(i => i.Product)
        .Take(500)
        .ToListAsync();
    Console.WriteLine($"Fetched: {list.Count}");
});

// 5) NoTracking + IdentityResolution (dedup sin tracking)
await Measure("NoTracking + IdentityResolution", async () =>
{
    var list = await db.Orders
        .AsNoTrackingWithIdentityResolution()
        .Include(o => o.Items)
        .Take(500)
        .ToListAsync();
    Console.WriteLine($"Fetched: {list.Count}");
});


// 6) DTO no compilado (control)
await Measure("DTO (no compiled)", async () =>
{
    var list = await db.Orders.AsNoTracking()
        .Select(o => new OrderDto(
            o.Id, o.Customer.Name, o.Items.Count,
            o.Items.Sum(i => i.Quantity * i.UnitPrice)))
        .Take(500)
        .ToListAsync();
    Console.WriteLine($"Fetched DTOs: {list.Count}");
});

// Definición de la consulta compilada (local, sin static/readonly)
var compiledDto = Microsoft.EntityFrameworkCore.EF.CompileQuery(
    (AppDbContext db, int take) =>
        db.Orders
          .AsNoTracking()
          .Select(o => new OrderDto(
              o.Id,
              o.Customer.Name,
              o.Items.Count,
              o.Items.Sum(i => i.Quantity * i.UnitPrice)))
          .Take(take)
);

// 7) DTO compilado (múltiples ejecuciones para ver mejora tras el warmup)
MeasureSync("DTO compiled (run 1)", () =>
{
    var list = compiledDto(db, 500).ToList();
    Console.WriteLine($"Fetched DTOs: {list.Count}");
});
MeasureSync("DTO compiled (run 2)", () =>
{
    var list = compiledDto(db, 500).ToList();
    Console.WriteLine($"Fetched DTOs: {list.Count}");
});
MeasureSync("DTO compiled (run 3)", () =>
{
    var list = compiledDto(db, 500).ToList();
    Console.WriteLine($"Fetched DTOs: {list.Count}");
});
// DTO local para no tocar más proyectos ahora

// ------- Escenarios extra: consultas útiles de verdad -------

Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");
Console.WriteLine("-------------------------------------------------------------------------------------------------------------------------------");

// 1) Include completo vs Filtered Include
await Measure("Include completo (Items)", async () =>
{
    var list = await db.Orders
        .AsNoTracking()
        .Include(o => o.Items)
        .OrderBy(o => o.Id)
        .Take(500)
        .ToListAsync();
    
    Console.WriteLine();
    Console.WriteLine($"Orders: {list.Count}, Items(media): {list.Average(o => o.Items.Count):F2}");
});

await Measure("Filtered Include (Items Qty>=2)", async () =>
{
    var list = await db.Orders
        .AsNoTracking()
        .Include(o => o.Items.Where(i => i.Quantity >= 2))
        .OrderBy(o => o.Id)
        .Take(500)
        .ToListAsync();

    Console.WriteLine();
    Console.WriteLine($"Orders: {list.Count}, Items(media): {list.Average(o => o.Items.Count):F2}");
});

// 2) Aggregates servidor vs sumar en memoria
await Measure("Aggregates server (TOP 50 productos)", async () =>
{
    var top = await db.OrderItems.AsNoTracking()
        .GroupBy(oi => oi.ProductId)
        .Select(g => new
        {
            ProductId = g.Key,
            Qty = g.Sum(x => x.Quantity),
            Total = g.Sum(x => x.Quantity * x.UnitPrice)
        })
        .OrderByDescending(x =>(double) x.Total)
        .Take(50)
        .ToListAsync();

    Console.WriteLine();
    Console.WriteLine($"Top: {top.Count}");
});

await Measure("Aggregates en memoria (naïve)", async () =>
{
    var items = await db.Orders.AsNoTracking()
        .Include(o => o.Items)
        .SelectMany(o => o.Items)
        .ToListAsync();

    var top = items
        .GroupBy(oi => oi.ProductId)
        .Select(g => new
        {
            ProductId = g.Key,
            Qty = g.Sum(x => x.Quantity),
            Total = g.Sum(x => x.Quantity * x.UnitPrice)
        })
        .OrderByDescending(x => x.Total)
        .Take(50)
        .ToList();

    Console.WriteLine();
    Console.WriteLine($"Top: {top.Count}");
});

// 3) EXISTS bien (Any) vs Count()>0 y LEFT JOIN opcional
await Measure("EXISTS con Any()", async () =>
{
    var list = await db.Customers.AsNoTracking()
        .Where(c => c.Orders.Any())
        .Take(500)
        .ToListAsync();

    Console.WriteLine();
    Console.WriteLine($"Customers con pedidos: {list.Count}");
});

await Measure("COUNT()>0 (comparativa)", async () =>
{
    var list = await db.Customers.AsNoTracking()
        .Where(c => c.Orders.Count() > 0)
        .Take(500)
        .ToListAsync();

    Console.WriteLine();
    Console.WriteLine($"Customers con pedidos: {list.Count}");
});

await Measure("LEFT JOIN opcional", async () =>
{
    var q =
        from o in db.Orders.AsNoTracking()
        join c in db.Customers on o.CustomerId equals c.Id into gj
        from c in gj.DefaultIfEmpty()
        orderby o.Id
        select new { o.Id, CustomerName = c != null ? c.Name : "(none)" };

    var list = await q.Take(500).ToListAsync();

    Console.WriteLine();
    Console.WriteLine($"Rows: {list.Count}");
});

// ------- Fin escenarios extra -------


Console.WriteLine("Done");
