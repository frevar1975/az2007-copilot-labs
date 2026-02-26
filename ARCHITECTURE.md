# Arquitectura del proyecto

Resumen técnico y decisiones de diseño para `az2007-copilot-labs` (proyecto `StoreApi`).

## Visión general

`StoreApi` es una API mínima basada en ASP.NET Core Minimal APIs (net8.0). Está diseñada como ejemplo didáctico para ilustrar conceptos de endpoints, configuración y documentación con Swagger.

## Componentes

- Frontend: no incluido (API-first demo).
- Backend: `src/StoreApi` – ASP.NET Core minimal API.
- Configuración: `appsettings.json` y `appsettings.Development.json`.

## Stack tecnológico

- Plataforma: .NET 8 (SDK)
- Framework web: ASP.NET Core Minimal APIs
- Documentación API: Swashbuckle / Swagger (AddSwaggerGen)

## Diagrama de alto nivel (texto)

Cliente (curl / navegador / app) -> HTTP -> StoreApi (ASP.NET Core Minimal API) -> Respuesta JSON

## Flujo de petición

1. El cliente realiza una petición HTTP al endpoint (por ejemplo `/weatherforecast`).
2. La aplicación define rutas en `Program.cs` con `MapGet` y otras funciones.
3. En entorno de desarrollo, Swagger UI está habilitado para explorar y probar endpoints.

## Decisiones de diseño

- Minimal APIs: elegidas por su simplicidad para demos y ejemplos pedagógicos.
- Swagger: habilitado en entorno de desarrollo para facilitar pruebas interactivas.
- No se forzó HTTPS en el template para simplificar ejecución local (la línea `app.UseHttpsRedirection()` está comentada).

## Escalabilidad y próximos pasos

- Para extender a producción, añadir: autenticación/autorización, validación de modelos, manejo centralizado de errores y persistencia (BD).
- Separar responsabilidades en capas (Controllers/Services/Repositories) si la complejidad crece.

## Despliegue

- Contenedor Docker: recomendable para despliegue reproducible.
- Plataformas: Azure App Service, Azure Container Apps, AKS o cualquier host que soporte .NET 8.

---

Si quieres, puedo generar también un `Dockerfile` y un pipeline CI básico para desplegar la API.
