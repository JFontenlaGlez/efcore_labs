using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore.Shared.Reporting;

public sealed record AggregatesDto(
    long Count, decimal Sum, decimal Avg, decimal Min, decimal Max);
