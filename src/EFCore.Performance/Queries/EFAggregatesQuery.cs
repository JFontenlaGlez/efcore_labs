using EfCore.Shared;
using EFCore.Shared.Reporting;
using Microsoft.EntityFrameworkCore;

namespace EFCore.Performance.Queries;

public sealed class EfAggregatesQuery : IAggregatesQuery
{
    private readonly AppDbContext _db;
    public EfAggregatesQuery(AppDbContext db) => _db = db;

    public async Task<AggregatesDto> GetAsync(DateTime fromUtc, int take, CancellationToken ct = default)
    {
        // 1) IDs de pedidos a considerar (por fecha y ordenando por los más recientes)
        var orderIds = _db.Orders
            .Where(o => o.CreatedAt >= fromUtc)
            .OrderByDescending(o => o.CreatedAt)
            .Select(o => o.Id)
            .Take(take);

        // 2) Total por pedido = Σ (Quantity * UnitPrice)
        //    (solo para los orderIds anteriores)
        var perOrderTotals = _db.OrderItems
            .Where(oi => orderIds.Contains(oi.OrderId))
            .GroupBy(oi => oi.OrderId)
            .Select(g => g.Sum(oi => oi.UnitPrice * oi.Quantity));

        // 3) Agregados sobre los totales por pedido
        var dto = await perOrderTotals
            .GroupBy(_ => 1)
            .Select(g => new AggregatesDto(
                g.LongCount(),
                g.Sum(x => (decimal?)x) ?? 0m,
                g.Average(x => (decimal?)x) ?? 0m,
                g.Min(x => (decimal?)x) ?? 0m,
                g.Max(x => (decimal?)x) ?? 0m
            ))
            .SingleOrDefaultAsync(ct);

        return dto ?? new AggregatesDto(0, 0m, 0m, 0m, 0m);
    }
}

