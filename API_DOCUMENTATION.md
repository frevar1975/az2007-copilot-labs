# Documentación de la API

Documentación de los endpoints expuestos por `StoreApi` (proyecto `src/StoreApi`).

## Resumen

La API es mínima y actualmente expone un endpoint para obtener un pronóstico del tiempo de ejemplo.

## Endpoints

- GET /weatherforecast
  - Descripción: Genera y devuelve un arreglo de objetos `WeatherForecast` para los próximos 5 días.
  - Respuesta: `200 OK` con body JSON — array de objetos.
  - Ejemplo de respuesta:

```json
[
  {
    "date": "2026-02-27",
    "temperatureC": 12,
    "summary": "Mild",
    "temperatureF": 53
  },
  {
    "date": "2026-02-28",
    "temperatureC": 8,
    "summary": "Cool",
    "temperatureF": 46
  }
]
```

  - Notas técnicas:
    - Endpoint definido en `Program.cs` con `app.MapGet("/weatherforecast", ...)`.
    - El tipo `WeatherForecast` es un `record` en `Program.cs` con propiedades `Date` (DateOnly), `TemperatureC` (int) y `Summary` (string). Se calcula `TemperatureF` a partir de `TemperatureC`.
    - Swagger/OpenAPI está habilitado en entorno de desarrollo (`app.UseSwagger()`, `app.UseSwaggerUI()`).

## Cómo probar

- Usando `curl`:

```bash
curl http://localhost:5000/weatherforecast
```

- Usando navegador (Swagger UI): arrancar la app en modo Development y abrir `http://localhost:<PORT>/swagger`.

## Recomendaciones para extender la API

- Añadir contratos DTO explícitos y validación de entrada si se aceptan datos de cliente.
- Añadir pruebas unitarias y de integración para cubrir comportamiento de endpoints.
- Exportar el OpenAPI (Swagger) a JSON/YAML para uso con clientes generados o herramientas de documentación.
