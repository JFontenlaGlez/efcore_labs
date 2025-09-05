# EF Core — RESULTS

**Entorno:** .NET 8.0.5 · Windows 10 · i7-8750H · SQLite  
**Metodología:** BenchmarkDotNet v0.15.2 + `[MemoryDiagnoser]` (tiempo y memoria por operación).  
**Ejecución recomendada:** `dotnet run -c Release --project benchmarks/EfCore.Benchmarks` (sin depurador).

> **Leyenda:**  
> Mean = tiempo medio · Allocated = memoria asignada por op. · Ratio = Mean / Baseline (menor es mejor).  
> Baseline = *Tracking + Include*.

---

## TL;DR (qué aplicar en código)
- **Lectura por defecto → Proyección a DTO.**  
- **DTO compilada** aporta cuando **repites** la misma consulta o con **páginas grandes**.  
- **AsNoTracking** con varios `Include` puede **empeorar** tiempo y memoria.  
- **SplitQuery** ayuda con **páginas pequeñas** y varias colecciones; con páginas grandes suele penalizar por viajes extra.

---

## Resultados

### Take = 50
| Método                         | Mean | Allocated | Notas |
|--------------------------------|-----:|----------:|------|
| **ProjectionDtoCompiled**      | **2.445 ms** | 137.95 KB | 🥇 tiempo |
| **ProjectionDto**              | 2.671 ms | 147.97 KB | muy cerca del compilado |
| **SplitQuery**                 | 3.786 ms | **123.68 KB** | 🥇 menor memoria |
| NoTrackingIdentityResolution   | 7.339 ms | 373.44 KB | sobrecoste claro |
| BaselineTrackingInclude        | 150.914 ms | 160.95 KB | referencia |
| AsNoTracking                   | 150.687 ms | 324.22 KB | similar en tiempo, peor en memoria |

**Claves:** con páginas pequeñas, DTO(s) arrasan en tiempo; SplitQuery ahorra memoria.

---

### Take = 500
| Método                         | Mean | Allocated |
|--------------------------------|-----:|----------:|
| **ProjectionDtoCompiled**      | **21.811 ms** | **1.24 MB** |
| **ProjectionDto**              | 22.321 ms | 1.28 MB |
| **SplitQuery**                 | 30.672 ms | 1.14 MB |
| BaselineTrackingInclude        | 194.626 ms | 1.33 MB |
| AsNoTracking                   | 217.576 ms | 2.79 MB |
| NoTrackingIdentityResolution   | 81.140 ms | 3.28 MB |

**Claves:** DTO(s) ≈ **10×** más rápidos que baseline; AsNoTracking puro empeora con `Include`.

---

### Take = 5000
| Método                         | Mean | Allocated |
|--------------------------------|-----:|----------:|
| **ProjectionDtoCompiled**      | **216.901 ms** | **12.60 MB** |
| **ProjectionDto**              | 218.659 ms | 12.61 MB |
| SplitQuery                     | 520.567 ms | 21.59 MB |
| BaselineTrackingInclude        | 636.394 ms | 13.46 MB |
| AsNoTracking                   | 893.602 ms | 29.09 MB |
| NoTrackingIdentityResolution   | 817.353 ms | 33.90 MB |

**Claves:** al escalar, **DTO compilada** se mantiene líder en tiempo y memoria.

---

### Take = 50 000 *(capado por datos)*
| Método                         | Mean | Allocated |
|--------------------------------|-----:|----------:|
| **ProjectionDto**              | **373.750 ms** | **24.68 MB** |
| **ProjectionDtoCompiled**      | 382.651 ms | 24.67 MB |
| BaselineTrackingInclude        | 1.210 s | 26.90 MB |
| SplitQuery                     | 1.384 s | 64.45 MB |
| NoTrackingIdentityResolution   | 1.531 s | 66.54 MB |
| AsNoTracking                   | 1.677 s | 56.84 MB |

> **Nota de “cap” de datos:** el seed actual (~10k Orders) hace que `Take=50k` traiga “todo”. Para probar 50k *reales*, incrementa el seed (p. ej., `orders: 120_000`) y usa un `SimpleJob` con menos iteraciones.

---

## Reproducibilidad
1. **Release**: `dotnet clean && dotnet run -c Release --project benchmarks/EfCore.Benchmarks`.  
2. **Sin depurador**: evita `AttachedDebugger` para números limpios.  
3. **Artefactos**: mira `BenchmarkDotNet.Artifacts/results/*.md|.html|.csv`.

## Reglas de decisión (rápidas)
- **Solo lectura** → **DTO**.  
- **Consulta muy frecuente / página grande** → **DTO compilada**.  
- **Muchas colecciones** y página **pequeña** → **SplitQuery**.  
- **Evita** `AsNoTracking` con `Include` a ciegas.  
- **IdentityResolution** en no-tracking: solo si hay **mucha reutilización** del mismo relacionado (medir antes).

## Anexos (opcionales)
- **Semilla “heavy”** para Take altos:
  ```csharp
  // QueryBenchmarks.Setup()
  DataSeeder.EnsureSeedAsync(_db, customers: 50_000, products: 5_000, orders: 120_000)
            .GetAwaiter().GetResult();


## Resultados en crudo

```

BenchmarkDotNet v0.15.2, Windows 10 (10.0.19045.6216/22H2/2022Update)
Intel Core i7-8750H CPU 2.20GHz (Coffee Lake), 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.300
  [Host]     : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2 [AttachedDebugger]
  DefaultJob : .NET 8.0.5 (8.0.524.21615), X64 RyuJIT AVX2


```
| Method                       | Take  | Mean         | Error      | StdDev      | Median       | Ratio | RatioSD | Rank | Gen0       | Gen1      | Gen2      | Allocated   | Alloc Ratio |
|----------------------------- |------ |-------------:|-----------:|------------:|-------------:|------:|--------:|-----:|-----------:|----------:|----------:|------------:|------------:|
| ProjectionDtoCompiled        | 50    |     2.445 ms |  0.0803 ms |   0.2316 ms |     2.417 ms |  0.02 |    0.00 |    1 |    23.4375 |         - |         - |   137.95 KB |        0.86 |
| ProjectionDto                | 50    |     2.671 ms |  0.0826 ms |   0.2358 ms |     2.602 ms |  0.02 |    0.00 |    2 |    31.2500 |         - |         - |   147.97 KB |        0.92 |
| SplitQuery                   | 50    |     3.786 ms |  0.1223 ms |   0.3431 ms |     3.727 ms |  0.03 |    0.00 |    3 |    15.6250 |         - |         - |   123.68 KB |        0.77 |
| NoTrackingIdentityResolution | 50    |     7.339 ms |  0.2009 ms |   0.5566 ms |     7.252 ms |  0.05 |    0.01 |    4 |    62.5000 |         - |         - |   373.44 KB |        2.32 |
| AsNoTracking                 | 50    |   150.687 ms |  3.3985 ms |   9.9135 ms |   148.528 ms |  1.01 |    0.10 |    5 |          - |         - |         - |   324.22 KB |        2.01 |
| BaselineTrackingInclude      | 50    |   150.914 ms |  4.6332 ms |  13.1437 ms |   146.592 ms |  1.01 |    0.12 |    5 |          - |         - |         - |   160.95 KB |        1.00 |
|                              |       |              |            |             |              |       |         |      |            |           |           |             |             |
| ProjectionDtoCompiled        | 500   |    21.811 ms |  0.7458 ms |   2.1636 ms |    21.340 ms |  0.11 |    0.01 |    1 |   250.0000 |   31.2500 |         - |   1271.8 KB |        0.94 |
| ProjectionDto                | 500   |    22.321 ms |  0.8274 ms |   2.3871 ms |    21.682 ms |  0.12 |    0.01 |    1 |   142.8571 |         - |         - |  1281.85 KB |        0.94 |
| SplitQuery                   | 500   |    30.672 ms |  0.6253 ms |   1.8339 ms |    30.324 ms |  0.16 |    0.01 |    2 |   214.2857 |   71.4286 |         - |  1168.05 KB |        0.86 |
| NoTrackingIdentityResolution | 500   |    81.140 ms |  4.3214 ms |  12.1178 ms |    78.731 ms |  0.42 |    0.07 |    3 |   500.0000 |         - |         - |  3361.29 KB |        2.47 |
| BaselineTrackingInclude      | 500   |   194.626 ms |  4.2602 ms |  12.2234 ms |   192.176 ms |  1.00 |    0.09 |    4 |          - |         - |         - |  1358.77 KB |        1.00 |
| AsNoTracking                 | 500   |   217.576 ms |  4.5808 ms |  13.0693 ms |   214.438 ms |  1.12 |    0.09 |    5 |   500.0000 |         - |         - |  2853.37 KB |        2.10 |
|                              |       |              |            |             |              |       |         |      |            |           |           |             |             |
| ProjectionDtoCompiled        | 5000  |   216.901 ms | 10.7195 ms |  30.9281 ms |   208.153 ms |  0.34 |    0.05 |    1 |  2000.0000 |         - |         - | 12602.23 KB |        0.91 |
| ProjectionDto                | 5000  |   218.659 ms |  7.6061 ms |  21.9454 ms |   214.794 ms |  0.34 |    0.04 |    1 |  2000.0000 |         - |         - | 12612.87 KB |        0.92 |
| SplitQuery                   | 5000  |   520.567 ms | 10.3129 ms |  29.0878 ms |   516.812 ms |  0.82 |    0.06 |    2 |  3000.0000 | 1000.0000 |         - |  21586.2 KB |        1.57 |
| BaselineTrackingInclude      | 5000  |   636.394 ms | 12.5477 ms |  34.5601 ms |   629.346 ms |  1.00 |    0.08 |    3 |  3000.0000 |         - |         - | 13776.15 KB |        1.00 |
| NoTrackingIdentityResolution | 5000  |   817.353 ms | 20.9255 ms |  60.0390 ms |   801.335 ms |  1.29 |    0.12 |    4 |  5000.0000 | 2000.0000 | 1000.0000 | 33895.71 KB |        2.46 |
| AsNoTracking                 | 5000  |   893.602 ms | 17.7618 ms |  49.5127 ms |   889.918 ms |  1.41 |    0.11 |    5 |  4000.0000 | 1000.0000 |         - | 29085.03 KB |        2.11 |
|                              |       |              |            |             |              |       |         |      |            |           |           |             |             |
| ProjectionDto                | 50000 |   373.750 ms |  7.4321 ms |  20.4702 ms |   371.043 ms |  0.31 |    0.02 |    1 |  5000.0000 | 1000.0000 |         - |  25276.5 KB |        0.92 |
| ProjectionDtoCompiled        | 50000 |   382.651 ms | 14.0213 ms |  40.4547 ms |   375.053 ms |  0.32 |    0.03 |    1 |  5000.0000 | 1000.0000 |         - | 25265.79 KB |        0.92 |
| BaselineTrackingInclude      | 50000 | 1,210.052 ms | 20.6717 ms |  29.6467 ms | 1,210.996 ms |  1.00 |    0.03 |    2 |  5000.0000 |         - |         - | 27554.42 KB |        1.00 |
| SplitQuery                   | 50000 | 1,384.378 ms | 27.2700 ms |  49.1735 ms | 1,380.935 ms |  1.14 |    0.05 |    3 | 10000.0000 | 2000.0000 |         - | 65991.44 KB |        2.39 |
| NoTrackingIdentityResolution | 50000 | 1,531.221 ms | 30.3980 ms |  59.2890 ms | 1,522.185 ms |  1.27 |    0.06 |    4 | 11000.0000 | 5000.0000 | 2000.0000 | 68125.82 KB |        2.47 |
| AsNoTracking                 | 50000 | 1,676.860 ms | 43.4183 ms | 125.2716 ms | 1,667.388 ms |  1.39 |    0.11 |    5 |  9000.0000 | 2000.0000 |         - | 58195.33 KB |        2.11 |