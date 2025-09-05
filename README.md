# ENTITY FRAMEWORK CORE PERFORMANCE — Study Playbook

## Objetivo
Aprender a **consultar de forma eficiente con EF Core**: cuándo usar `Tracking/NoTracking`, **Proyección a DTO**, `AsSplitQuery`, **IdentityResolution** y **Compiled Queries**; medir **tiempo y memoria** con BenchmarkDotNet y aplicar estos hallazgos en código real.

## Roadmap (micro-pasos)
- [x] Paso 1 — Semilla + build: BD SQLite (`eflab.db`) y entidades / DbContext listos.
- [x] Paso 2 — Demos rápidas: Baseline (tracking + Include) vs `AsNoTracking`.
- [x] Paso 3 — **Proyección a DTO** (carga mínima).
- [x] Paso 4 — `AsSplitQuery` (evitar cartesianas con varios Include).
- [x] Paso 5 — `AsNoTrackingWithIdentityResolution` (deduplicación en no-tracking).
- [x] Paso 6 — **Compiled Query** (`EF.CompileQuery`) y concepto de **calentamiento**.
- [x] Paso 7 — **BenchmarkDotNet** con `[MemoryDiagnoser]` (tiempo + memoria) y `Take={500,5000}`.
- [ ] Paso 8 — **Migraciones reales**: `dotnet-ef`, `MigrateAsync()` (reemplazar `EnsureCreated`).
- [ ] Paso 9 — **Paginación eficiente**: `Skip/Take` vs **Keyset/Seek** (+ benchmark).
- [ ] Paso 10 — **Índices & tuning**: índices compuestos y medición del impacto.
- [ ] Paso 11 — **Concurrencia y transacciones**: `RowVersion`, retries, `BeginTransaction`.
- [ ] Paso 12 — **Lotes**: `AutoDetectChangesEnabled=false`, `AddRange`, `SaveChanges(false)`.
- [ ] Paso 13 — **Interception & logging**: `LogTo`, `IDbCommandInterceptor`, `TagWith`.
- [ ] Paso 14 — **Raw SQL / FromSql** con DTO para casos límite.

## Resumen técnico
(EN) **Default for read paths** is DTO projection to reduce materialization and allocations. Compiled queries help when repeating the same query or large pages. `AsNoTracking` is not always faster with multiple `Include`s due to duplication; `AsSplitQuery` helps for small pages with many collections. Use BDN to validate time & memory before adopting a pattern.

(ES) **Para lectura por defecto, proyecta a DTO** (menos materialización y memoria). Las **consultas compiladas** ayudan cuando repites la misma consulta o con páginas grandes. `AsNoTracking` con varios `Include` puede empeorar por duplicado de objetos; **`AsSplitQuery`** ayuda en páginas pequeñas con varias colecciones. **Mide** con BenchmarkDotNet (tiempo y memoria) antes de fijar un patrón.

## Prácticas / Labs
- `src/EfCore.Basics` — **Lab 01: Seed**  
  *Criterios:* crea `eflab.db` y muestra “Seed OK”. *Métrica:* build sin errores.
- `src/EfCore.Performance` — **Lab 02: Baseline vs NoTracking**  
  *Criterios:* dos tiempos y `Fetched: N` iguales. *Métrica:* ms.
- `src/EfCore.Performance` — **Lab 03: Proyección a DTO**  
  *Criterios:* tiempo < Baseline. *Métrica:* ms.
- `src/EfCore.Performance` — **Lab 04: SplitQuery**  
  *Criterios:* comparar vs Baseline con múltiples `Include`. *Métrica:* ms.
- `src/EfCore.Performance` — **Lab 05: IdentityResolution**  
  *Criterios:* evaluar si reduce duplicados en tu forma de datos. *Métricas:* ms/MB.
- `src/EfCore.Performance` — **Lab 06: Compiled Query + warm-up**  
  *Criterios:* steady-state comparable; notar mejora en consultas repetidas/grandes. *Métrica:* ms.
- `benchmarks/EfCore.Benchmarks` — **Lab 07: Benchmarks tiempo+memoria**  
  *Criterios:* BDN en Release, tablas con **Mean** y **Allocated**. *Métricas:* ms y B/op.
- *(Pendiente)* `src/EfCore.Shared` — **Lab 08: Migraciones reales**  
  *Criterios:* carpeta `Migrations/`; usar `MigrateAsync()`. *Métrica:* arranque OK.
- *(Pendiente)* `benchmarks/EfCore.Benchmarks` — **Lab 09: Paginación (Seek vs Offset)**  
  *Criterios:* Mean estable con Keyset. *Métricas:* ms y B/op.

## Conclusiones
- Lo aprendido:
  - DTO **gana por defecto** en tiempo y memoria para lectura.
  - **Compilada** supera a DTO normal al escalar tamaño o repetir la consulta.
  - `AsNoTracking` no es panacea con `Include`s múltiples; **SplitQuery** ayuda en páginas pequeñas con varias colecciones.
- Próxima acción (≤15 min):
  - Añadir **migración Initial** y cambiar a `MigrateAsync()` en `EfCore.Basics` (ver Roadmap Paso 8).

## Métricas
| Métrica  | Cómo medir                                    | Valor inicial |
|----------|-----------------------------------------------|---------------|
| Tests    | `dotnet test`                                 | (pendiente)   |
| Latencia | `dotnet run -c Release` (BDN) / `Performance` | OK            |
| Commits  | `git log --oneline`                           | ≥ 5           |

## Enlaces útiles
- Documentación oficial:  
  - EF Core Docs — *Querying, Performance, Tracking, Migrations*.  
- Tutorial paso a paso:  
  - *Getting started with EF Core (SQLite + Migrations)*.  
- Cheatsheet:  
  - *EF Core performance checklist (DTO, NoTracking, SplitQuery, Compiled)*.  
- Ejemplos de código:  
  - Este repo: `src/EfCore.Performance` y `benchmarks/EfCore.Benchmarks`.
# {TEMA} — Study Playbook

## Objetivo
Escribir aquí qué voy a aprender en este repo.

## Roadmap (micro-pasos)
- [ ] Paso 1 …
- [ ] Paso 2 …

## Resumen técnico
(EN) Short summary in English…
(ES) Resumen en español…

## Prácticas / Labs
- `labs/01-...` → descripción, criterios de aceptación y métricas

## Conclusiones
- Lo aprendido:
- Próxima acción (≤15 min):

## Métricas
| Métrica | Cómo medir | Valor |
|---------|------------|-------|
| Tests   | dotnet test|       |
| Latencia| bombardier |       |
| Commits | git log    |       |

## Enlaces útiles
- Documentación oficial:
- Tutorial paso a paso:
- Cheatsheet:
- Ejemplos de código:
