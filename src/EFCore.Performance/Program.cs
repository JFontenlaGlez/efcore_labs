using System.Diagnostics;
using EfCore.Shared;
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

Console.WriteLine("Done");
