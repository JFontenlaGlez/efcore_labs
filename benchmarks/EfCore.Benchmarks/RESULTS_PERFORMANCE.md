## Escenarios útiles (Release, TAKE_ORDERS=1000, TOP_N=50, SQLite)

| Escenario                                  | Latencia |
|--------------------------------------------|---------:|
| Include completo (Items)                    | 75 ms    |
| Filtered Include (Items Qty ≥ 2)           | **51 ms** (–32% vs Include) |
| Filtered Include (Qty ≥ 3 & últimos 90d)   | **48 ms** (–36% vs Include) |
| Aggregates **server** (TOP 50 productos)   | 111 ms   |
| Aggregates **en memoria** (naïve justo)    | **65 ms** |
| EXISTS con `Any()`                          | 10 ms    |
| `Count() > 0` (comparativa)                 | 9 ms     |
| LEFT JOIN (relación opcional)               | 32 ms    |

**Claves:**
- Filtrar hijos **reduce latencia** de forma consistente; añade ventanas temporales si aplica (p. ej., últimos 90 días).
- En SQLite y dataset actual, el **aggregate en memoria** puede ser más rápido; **no** significa que sea mejor patrón: el aggregate **en servidor** debe asignar **mucha menos memoria** (y en SQL Server suele ser más rápido). 
- `Any()` ≈ `Count()>0` en tiempo aquí; **prefiere `Any()`** por semántica y traducción.
- LEFT JOIN evita N+1 y mantiene latencias estables.

**Acciones derivadas:**
- Medir **Allocated** (B/op) de *server vs naïve* en BenchmarkDotNet para decidir con datos completos (tiempo **y** memoria).
- Documentar en el README cuándo aplicar Filtered Include y ventanas de tiempo.
