# AZ-2007  
# Laboratorio con Cronograma  
# GitHub Copilot aplicado a una Product Catalog API

Autor: Freddy Vargas  
Curso: AZ-2007  
Duración total estimada: 100 minutos  

---

# 🕒 Estructura del Laboratorio

| Fase | Actividad | Tiempo |
|------|------------|--------|
| Fase 1 | Crear API base | 15 min |
| Fase 2 | Análisis inteligente | 20 min |
| Fase 3 | Documentación insertada | 20 min |
| Fase 4 | Documentación del proyecto | 15 min |
| Fase 5 | Modo Agente | 15 min |
| Fase 6 | Pruebas unitarias | 10 min |
| Fase 7 | Reflexión | 5 min |
| **Total** | | **100 min** |

---

# 🔹 FASE 1 – Crear Product Catalog API (15 min)

## Paso 1 – Crear proyecto

```bash
dotnet new webapi -n ProductCatalogApi
cd ProductCatalogApi
code .
```

Eliminar WeatherForecast.

---

## Paso 2 – Crear modelo Product

Crear carpeta `Models`  
Archivo: `Product.cs`

```csharp
namespace ProductCatalogApi.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
}
```

---

## Paso 3 – Crear controlador básico

Crear carpeta `Controllers`  
Archivo: `ProductsController.cs`

```csharp
using Microsoft.AspNetCore.Mvc;
using ProductCatalogApi.Models;

namespace ProductCatalogApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProductsController : ControllerBase
{
    private static List<Product> _products = new();

    [HttpGet]
    public IActionResult Get()
    {
        return Ok(_products);
    }

    [HttpPost]
    public IActionResult Create(Product product)
    {
        product.Id = _products.Count + 1;
        _products.Add(product);
        return CreatedAtAction(nameof(Get), product);
    }
}
```

Ejecutar:

```bash
dotnet run
```

Probar endpoints en Swagger.

---

# 🔹 FASE 2 – Análisis Inteligente (20 min)

## Objetivo
Analizar arquitectura y diseño usando Copilot.

---

## Actividad 1 – Analizar arquitectura (7 min)

Modo Preguntar:

```
@workspace Explain the architecture of this API.
```

---

## Actividad 2 – Evaluar diseño del controlador (7 min)

```
Review this controller and suggest improvements for production use.
```

Esperar sugerencias como:
- Separar lógica en servicio
- Validaciones
- Logging
- Manejo de errores

---

## Actividad 3 – Detectar riesgos (6 min)

```
What are the risks of using a static List for data storage?
```

Discusión sobre:
- Concurrencia
- Persistencia
- Escalabilidad

---

# 🔹 FASE 3 – Documentación Insertada (20 min)

## Actividad 1 – Documentar modelo (7 min)

Seleccionar clase `Product`.

```
/doc
```

---

## Actividad 2 – Documentar controlador completo (7 min)

```
Document this controller including endpoint descriptions.
```

---

## Actividad 3 – Acción Inteligente (6 min)

Seleccionar método `Create()` → Generate Docs.

Comparar resultados.

---

# 🔹 FASE 4 – Documentación del Proyecto (15 min)

## Crear README profesional (10 min)

Modo Edición:

```
Create a professional README.md including:
- Project description
- API endpoints
- Example JSON requests
- How to run locally
- Technology stack
```

---

## Mejorar README (5 min)

```
Improve this README to follow open source best practices.
```

---

# 🔹 FASE 5 – Modo Agente (15 min)

## Automatización global

Cambiar a modo Agente:

```
Refactor this API to follow clean architecture principles.
```

Observar propuesta:
- Crear carpeta Services
- Separar lógica
- Inyectar dependencias

---

## Documentación completa

```
Generate documentation for all public classes in this project.
```

---

# 🔹 FASE 6 – Generar Pruebas Unitarias (10 min)

```
Generate unit tests for ProductsController using xUnit.
```

Crear proyecto:

```bash
dotnet new xunit -n ProductCatalogApi.Tests
```

Ejecutar:

```bash
dotnet test
```

---

# 🔹 FASE 7 – Reflexión (5 min)

Responder:

1. ¿Qué mejoras estructurales propuso Copilot?
2. ¿Qué revisarías antes de usar en producción?
3. ¿Cuándo usarías modo Agente en un entorno real?
4. ¿Confías 100% en el código generado?

---

# 📊 Comparativa Final

| Modo | Uso Ideal | Automatización |
|------|------------|---------------|
| Preguntar | Análisis conceptual | Bajo |
| Edición | Actualización controlada | Medio |
| Agente | Refactorización global | Alto |

---

# 🏁 Resultado Esperado

Al finalizar:

- API CRUD básica funcional
- Código documentado
- README profesional
- Refactorización propuesta
- Tests generados

---

# 🚀 Conclusión

Este laboratorio demuestra que Copilot:

- Analiza arquitectura
- Detecta riesgos técnicos
- Mejora diseño
- Documenta automáticamente
- Genera pruebas
- Propone refactorizaciones

Pero el desarrollador sigue tomando decisiones finales.

---

# 🔥 FIN – LAB PRODUCT CATALOG API