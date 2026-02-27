# AZ-2007  
# LAB 02 – Product Catalog API + GitHub Copilot  
# Análisis, Documentación y Automatización

Duración total estimada: 100 minutos  
Nivel: Intermedio  
Proyecto: ProductCatalogApi (.NET 8 + Swagger + Controllers)

---

# 🕒 Cronograma del Laboratorio

| Fase | Actividad | Tiempo |
|------|------------|--------|
| 1 | Crear API + Swagger | 20 min |
| 2 | Análisis con Copilot | 20 min |
| 3 | Documentación insertada | 20 min |
| 4 | Documentación del proyecto | 15 min |
| 5 | Modo Agente | 15 min |
| 6 | Pruebas unitarias | 10 min |
| **Total** | | **100 min** |

---

# 🔹 FASE 1 – Crear Product Catalog API (20 min)

## 1️⃣ Crear proyecto

```bash
dotnet new webapi -n ProductCatalogApi
cd ProductCatalogApi
code .
```

Eliminar WeatherForecast si existe.

---

## 2️⃣ Instalar Swagger

```bash
dotnet add package Swashbuckle.AspNetCore
```

---

## 3️⃣ Configurar Program.cs

Reemplazar todo por:

```csharp
var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseAuthorization();
app.MapControllers();

app.Run();
```

---

## 4️⃣ Crear modelo Product

Crear carpeta `Models`

Archivo: `Product.cs`

```csharp
namespace ProductCatalogApi.Models;

public class Product
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public decimal Price { get; set; }
    public bool IsActive { get; set; }
}
```

---

## 5️⃣ Crear controlador

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
    private static readonly List<Product> _products = new();

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

---

## 6️⃣ Ejecutar

```bash
dotnet run
```

Abrir:

```
http://localhost:5241/swagger
```

Probar:

POST → Crear producto  
GET → Listar productos  

---

# 🔹 FASE 2 – Análisis Inteligente con Copilot (20 min)

## 🎯 Objetivo
Analizar arquitectura y diseño real.

---

## Actividad 1 – Arquitectura completa

Modo Preguntar:

```
@workspace Explain the architecture of this API.
```

---

## Actividad 2 – Revisar controlador

```
Review this controller and suggest improvements for production use.
```

Analizar sugerencias:
- Separación en servicio
- Validaciones
- Logging
- Manejo de errores

---

## Actividad 3 – Riesgos técnicos

```
What are the risks of using a static List for data storage?
```

Esperar análisis sobre:
- Concurrencia
- Persistencia
- Escalabilidad

---

# 🔹 FASE 3 – Documentación Insertada (20 min)

## Actividad 1 – Documentar modelo

Seleccionar clase Product:

```
/doc
```

---

## Actividad 2 – Documentar controlador

```
Document this controller including endpoint descriptions.
```

---

## Actividad 3 – Acción Inteligente

Seleccionar método Create()  
Clic derecho → Generate Docs

Comparar resultados.

---

# 🔹 FASE 4 – Documentación del Proyecto (15 min)

## Crear README profesional

Modo Edición:

```
Create a professional README.md including:
- Project description
- API endpoints
- Example JSON requests
- How to run locally
- Technology stack
```

Aceptar cambios.

---

## Mejorar README

```
Improve this README to follow open source best practices.
```

---

# 🔹 FASE 5 – Modo Agente (15 min)

Cambiar a modo Agente.

## Refactorización estructural

```
Refactor this API to follow clean architecture principles.
```

Observar propuesta:
- Services
- Separación lógica
- Inyección de dependencias

---

## Documentación global automática

```
Generate documentation for all public classes in this project.
```

---

# 🔹 FASE 6 – Pruebas Unitarias (10 min)

## Generar pruebas

```
Generate unit tests for ProductsController using xUnit.
```

## Crear proyecto de pruebas

```bash
dotnet new xunit -n ProductCatalogApi.Tests
dotnet test
```

---

# 📊 Comparativa de Modos

| Modo | Uso Ideal | Nivel Automatización |
|------|------------|---------------------|
| Preguntar | Análisis conceptual | Bajo |
| Edición | Cambios controlados | Medio |
| Agente | Automatización global | Alto |

---

# 🧠 Reflexión Final

1. ¿Qué mejoras propuso Copilot?
2. ¿Qué validarías antes de producción?
3. ¿Cuándo usarías modo Agente?
4. ¿Confías 100% en el código generado?

---

# 🏁 Resultado Esperado

Al finalizar el LAB 02:

- API CRUD básica funcional
- Swagger activo
- Código documentado
- README profesional generado
- Refactorización propuesta
- Tests creados

---

# 🚀 Conclusión

Este laboratorio demuestra que GitHub Copilot:

- Analiza arquitectura
- Detecta riesgos
- Documenta automáticamente
- Genera pruebas
- Sugiere mejoras estructurales

El desarrollador mantiene la responsabilidad técnica final.

---

# 🔥 FIN – LAB 02 AZ-2007