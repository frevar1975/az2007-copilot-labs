# az2007-copilot-labs

Proyecto de laboratorio y ejemplos para la asignatura AZ2007: API Web con ASP.NET Core.

## Resumen

Este repositorio contiene dos proyectos de ejemplo:

- `StoreApi` — ejemplo minimal API en .NET (ubicado en `src/StoreApi`).
- `ProductCatalogApi` — ejemplo tradicional con controladores MVC/ApiController (ubicado en `ProductCatalogApi/ProductCatalogApi`).

Los ejemplos están diseñados para uso educativo y demuestran conceptos como endpoints, controladores, y configuración mínima de Swagger.

## Estructura relevante

- ProductCatalogApi/
  - ProductCatalogApi.csproj
  - Controllers/ProductsController.cs
  - models/Product.cs
- src/StoreApi/
  - StoreApi.csproj
  - Program.cs (Minimal API + ejemplo `WeatherForecast`)

## Ejecutar localmente

Requisitos: .NET SDK (versión compatible con los proyectos, p. ej. .NET 8 / .NET 10 según cada proyecto).

Desde la raíz del repositorio puede ejecutar cualquiera de los proyectos:

```powershell
cd ProductCatalogApi\ProductCatalogApi
dotnet run
```

o

```powershell
cd src\StoreApi
dotnet run
```

Luego abra `https://localhost:{PORT}/swagger` (si Swagger está habilitado en desarrollo) o haga peticiones a los endpoints expuestos.

## Endpoints principales (ejemplo `ProductCatalogApi`)

- `GET /api/products` — obtiene la lista de productos (demo: almacenamiento en memoria).
- `POST /api/products` — crea un producto (demo: la API asigna un Id y devuelve `201 Created`).

Observación: el controlador actual `ProductsController` utiliza una `static List<Product>` en memoria — ver `ProductCatalogApi/Controllers/ProductsController.cs`.

## Consideraciones y recomendaciones para producción

El código incluido es adecuado para demostraciones pero NO para producción. Riesgos y mejoras recomendadas:

- Persistencia: sustituir la `static List<T>` por una capa de persistencia (EF Core, SQL, Cosmos DB, etc.).
- Concurrencia: `List<T>` no es seguro para concurrencia; usar repositorios transaccionales o colecciones thread-safe durante pruebas.
- Identificadores: evitar `Id = _products.Count + 1`; usar identidad de BD o `Interlocked.Increment` en soluciones in-memory temporales.
- API design: agregar `GET /api/products/{id}`, validación con DTOs, protección contra over-posting, y `CreatedAtAction` con `routeValues`.
- Asincronía: usar métodos `async` y `CancellationToken` para operaciones I/O.
- Manejo de errores: centralizar con middleware de excepciones que devuelva `ProblemDetails` y códigos HTTP apropiados.
- Seguridad: forzar HTTPS, habilitar autenticación/autorization para mutaciones, aplicar CORS y rate-limiting.
- Observabilidad: añadir `ILogger`, trazas distribuidas (correlation ID), y métricas.
- Escalabilidad: no confiar en memoria local para datos si hay múltiples instancias detrás de un balanceador.

Si desea, puedo generar un `IProductRepository` simple con implementación en memoria segura para pruebas, o scaffolding con EF Core + migraciones.

## Contribuir

1. Cree una rama con un nombre descriptivo.
2. Abra un Pull Request con la descripción de los cambios.

## Tests

No hay pruebas automatizadas incluidas en este laboratorio. Se recomienda agregar pruebas unitarias para controladores y pruebas de integración contra una base de datos en memoria o fixtures.

## Licencia

Este repositorio está destinado a uso educativo; consulte al instructor o responsable del contenido para detalles de licencia y redistribución.

---
Para ayuda adicional o para que implemente las mejoras sugeridas (repositorio/DI, DTOs, async, EF Core scaffold), indíquelo y lo implemento.
