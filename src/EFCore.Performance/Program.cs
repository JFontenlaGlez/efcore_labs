using System.Diagnostics;
using EfCore.Shared;
using EFCore.Shared;
using Microsoft.EntityFrameworkCore;

static async Task Measure(string name, Func<Task> act)
{
    var sw = Stopwatch.StartNew();
    await act();
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

// DTO local para no tocar más proyectos ahora

Console.WriteLine("Done");

