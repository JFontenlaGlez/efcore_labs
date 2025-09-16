using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Shared.Reporting;

public interface IAggregatesQuery
{
    Task<AggregatesDto> GetAsync(DateTime fromUtc, int take, CancellationToken ct = default);
}
