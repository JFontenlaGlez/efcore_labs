namespace EfCore.Benchmarks;

using BenchmarkDotNet.Attributes;
using EfCore.Shared;
using EFCore.Shared;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

[MemoryDiagnoser] // Mide memoria (B/op) además del tiempo
[RankColumn]
[Orderer(BenchmarkDotNet.Order.SummaryOrderPolicy.FastestToSlowest)]
public class QueryBenchmarks
{
    private AppDbContext _db = default!;
    private Func<AppDbContext, int, IEnumerable<OrderDto>> _compiledDto = default!;

    // probamos con 500 y 5000 registros
    //[Params(500, 5000, 50000, 500000)]
    [Params(50, 500, 5000)]
    public int Take { get; set; }

    [GlobalSetup]
    public void Setup()
    {
        // Cada ejecución de BDN usa su carpeta bin; garantizamos BD y datos ahí
        _db = new AppDbContext(Db.Sqlite("eflab.db"));
        DataSeeder.EnsureSeedAsync(_db, customers: 5000, products: 5000, orders: 10000)
                  .GetAwaiter().GetResult();

        _compiledDto = Microsoft.EntityFrameworkCore.EF.CompileQuery(
            (AppDbContext db, int take) =>
                db.Orders.AsNoTracking()
                  .Select(o => new OrderDto(
                      o.Id, o.Customer.Name, o.Items.Count,
                      o.Items.Sum(i => i.Quantity * i.UnitPrice)))
                  .Take(take)
        );
    }

    [Benchmark(Baseline = true)]
    public Task<List<Order>> BaselineTrackingInclude() =>
        _db.Orders
           .Include(o => o.Customer)
           .Include(o => o.Items).ThenInclude(i => i.Product)
           .Take(Take).ToListAsync();

    [Benchmark]
    public Task<List<Order>> AsNoTracking() =>
        _db.Orders.AsNoTracking()
           .Include(o => o.Customer)
           .Include(o => o.Items).ThenInclude(i => i.Product)
           .Take(Take).ToListAsync();

    [Benchmark]
    public Task<List<OrderDto>> ProjectionDto() =>
        _db.Orders.AsNoTracking()
           .Select(o => new OrderDto(
               o.Id, o.Customer.Name, o.Items.Count,
               o.Items.Sum(i => i.Quantity * i.UnitPrice)))
           .Take(Take).ToListAsync();

    [Benchmark]
    public Task<List<Order>> SplitQuery() =>
        _db.Orders.AsNoTracking().AsSplitQuery()
           .Include(o => o.Customer)
           .Include(o => o.Items).ThenInclude(i => i.Product)
           .Take(Take).ToListAsync();

    [Benchmark]
    public Task<List<Order>> NoTrackingIdentityResolution() =>
        _db.Orders.AsNoTrackingWithIdentityResolution()
           .Include(o => o.Items)
           .Take(Take).ToListAsync();

    [Benchmark]
    public List<OrderDto> ProjectionDtoCompiled() =>
        _compiledDto(_db, Take).ToList();
    public class TopDto { public int ProductId; public int Qty; public decimal Total; }

}
