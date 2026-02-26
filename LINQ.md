# LINQ: explicación de la línea seleccionada

Código seleccionado:

```csharp
var result = items.Where(x => x.IsActive).ToList();
```

Esta línea utiliza LINQ para filtrar la secuencia `items`, seleccionando únicamente los elementos cuyo miembro `IsActive` es verdadero, y luego materializa el resultado en una nueva lista asignada a `result`.

`Where(x => x.IsActive)` devuelve un iterador perezoso (`IEnumerable<T>`) que representa la operación de filtrado pero no la ejecuta inmediatamente. La llamada a `ToList()` fuerza la evaluación inmediato del pipeline de LINQ y copia los elementos coincidentes en una instancia de `List<T>`, por eso `result` contendrá ya los elementos filtrados en memoria.

Puntos importantes y buenas prácticas:

- Null-safety: si `items` puede ser `null`, la expresión lanzará una `NullReferenceException`. Para evitarlo, comprueba `items` o usa el operador de navegación segura:

```csharp
var result = items?.Where(x => x != null && x.IsActive).ToList() ?? new List<YourItemType>();
```

- Elementos nulos: si la colección puede contener elementos `null`, valida `x != null` antes de acceder a `x.IsActive`.

- Evaluación y memoria: `ToList()` aloca una colección con todos los elementos resultantes. En escenarios con colecciones grandes o cuando prefieres procesar de forma perezosa, evita `ToList()` y trabaja con `IEnumerable<T>` o usa `AsEnumerable()`/`AsQueryable()` según corresponda.

- Diferencia entre `IEnumerable` e `IQueryable`: si `items` proviene de una fuente remota (por ejemplo, Entity Framework `DbSet<T>`), `Where` se traducirá a una consulta (SQL) solo si trabajas con `IQueryable<T>`. Llamar a `ToList()` en ese contexto ejecutará la consulta contra la base de datos y traerá los resultados.

- Rendimiento: para operaciones simples el impacto es mínimo, pero evita materializar colecciones innecesariamente en pipelines donde puedas encadenar más transformaciones o procesar resultados de manera secuencial.

Alternativas y variaciones útiles:

- Obtener un array en lugar de lista:

```csharp
var arr = items.Where(x => x.IsActive).ToArray();
```

- Mantener la evaluación perezosa:

```csharp
IEnumerable<MyType> query = items.Where(x => x.IsActive);
foreach(var it in query) { /* procesar sin cargar todo en memoria */ }
```

- Cuando uses EF Core y quieres ejecutar la consulta de forma asíncrona:

```csharp
var result = await dbContext.Items.Where(x => x.IsActive).ToListAsync();
```

Resumen: la línea es una forma idiomática y concisa de filtrar y obtener una colección en memoria de los elementos activos. Antes de usar `ToList()` considera si necesitas materializar la colección, si la fuente puede ser `null` o si trabajas con `IQueryable` (fuente remota), y aplica las defensas y patrones apropiados según el escenario.
