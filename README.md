
# az2007-copilot-labs

Repositorio de ejemplo usado en el curso AZ2007 para demostraciones con Copilot y prácticas con .NET.

## Visión general

Este repositorio contiene una solución .NET con un proyecto mínimo llamado `StoreApi` (ubicado en `src/StoreApi`) que demuestra una API construida con Minimal APIs de ASP.NET Core y documentación automática vía Swagger.

Archivos de documentación técnicos adicionales:

- `ARCHITECTURE.md` — arquitectura y decisiones técnicas.
- `API_DOCUMENTATION.md` — descripción de los endpoints y ejemplos.
- `CONTRIBUTING.md` — guía para contribuir al proyecto.

## Estructura principal

- `az2007-copilot-labs.sln` — solución .NET.
- `src/StoreApi/` — proyecto ASP.NET Core Web API.
  - `appsettings.json` y `appsettings.Development.json` — configuraciones.
  - `Program.cs` — entrada de la aplicación y definición de endpoints.

## Requisitos

- .NET SDK 8.0 (o versión compatible con el proyecto).

## Ejecutar localmente

Abrir terminal en la carpeta `src/StoreApi` y ejecutar:

```powershell
cd src/StoreApi
dotnet restore
dotnet build
dotnet run
```

Por defecto la aplicación expone Swagger en entorno de desarrollo. Si quieres forzar una URL específica antes de arrancar:

```powershell
$env:ASPNETCORE_URLS = "http://localhost:5000"
dotnet run
```

## Notas

- La API actual es mínima (ej. endpoint `/weatherforecast`). Consulta `API_DOCUMENTATION.md` para detalles y ejemplos de uso.
- Añade una licencia si planeas publicar este repositorio.

---

¿Quieres que genere ejemplos de llamadas `curl`, un archivo `launch.json` para VS Code o un esquema OpenAPI exportado? 
