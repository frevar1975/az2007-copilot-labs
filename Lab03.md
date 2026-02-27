# 🎓 AZ-2007 – LAB 03
# Modernización de Código Legado con GitHub Copilot

---

## 🎯 Objetivo del laboratorio

En este laboratorio usarás GitHub Copilot para:

- Analizar código legado
- Detectar problemas de diseño
- Aplicar buenas prácticas modernas
- Refactorizar usando patrones
- Agregar validaciones
- Generar pruebas unitarias
- Realizar una revisión técnica final

Este laboratorio es completamente independiente de los anteriores.

---

## ⏱ Duración estimada

| Actividad | Tiempo |
|------------|--------|
| Setup inicial | 5 min |
| Análisis con Copilot | 5 min |
| Refactor con Enum | 5 min |
| Strategy Pattern | 10 min |
| Validaciones | 5 min |
| Async + separación | 5 min |
| Pruebas unitarias | 10 min |
| Code Review final | 5 min |

Duración total aproximada: **45–50 minutos**

---

# 🔹 Paso 1 – Crear proyecto desde cero

En consola:

```bash
dotnet new console -n LegacyRefactorLab
cd LegacyRefactorLab
code .
```

---

# 🔹 Paso 2 – Agregar código legado

Reemplaza el contenido de `Program.cs` por:

```csharp
using System;

class OrderProcessor
{
    public double ProcessOrder(double price, int quantity, string customerType)
    {
        double total = price * quantity;

        if (customerType == "VIP")
        {
            total = total - (total * 0.1);
        }

        if (customerType == "Employee")
        {
            total = total - (total * 0.2);
        }

        if (total > 1000)
        {
            total = total - 50;
        }

        return total;
    }
}

class Program
{
    static void Main()
    {
        var processor = new OrderProcessor();
        var result = processor.ProcessOrder(200, 6, "VIP");
        Console.WriteLine($"Final price: {result}");
    }
}
```

Ejecutar:

```bash
dotnet run
```

---

# 🔹 Parte 1 – Análisis del código (Modo Preguntar)

Abrir la Vista de Chat → Modo **Preguntar**.

Usar el siguiente prompt:

```
Analyze this class and list design problems and potential improvements.
```

Revisar:

- Uso de strings mágicos
- Falta de validación
- Violación del principio Open/Closed
- Lógica de negocio acoplada
- Falta de testabilidad

---

# 🔹 Parte 2 – Reemplazar Strings por Enum

Prompt:

```
Refactor this code to replace string customer types with an enum.
```

Verificar que se genere:

```csharp
public enum CustomerType
{
    Regular,
    VIP,
    Employee
}
```

Actualizar el método para usar el enum.

---

# 🔹 Parte 3 – Aplicar Strategy Pattern

Prompt:

```
Refactor this order processing logic using the Strategy pattern.
Each customer type should have its own discount strategy.
```

Verificar que se generen:

- Interface `IDiscountStrategy`
- Clases concretas para cada tipo
- Refactor del `OrderProcessor`

---

# 🔹 Parte 4 – Agregar validaciones

Prompt:

```
Add proper input validation:
- Price must be greater than 0
- Quantity must be positive
- CustomerType must be valid
```

Validar que incluya:

- Guard clauses
- ArgumentException

---

# 🔹 Parte 5 – Modernizar con async y separación

Prompt:

```
Refactor this code to simulate async order processing and move logic to a service class.
```

Verificar:

- Creación de `OrderService`
- Método `async`
- Separación de responsabilidades

---

# 🔹 Parte 6 – Generar pruebas unitarias

Crear proyecto de pruebas:

```bash
dotnet new xunit -n LegacyRefactorLab.Tests
dotnet add LegacyRefactorLab.Tests reference LegacyRefactorLab
```

Prompt en Copilot:

```
Generate xUnit tests for OrderProcessor.
Cover VIP, Employee and bulk discount scenarios.
```

Verificar:

- Casos normales
- Casos límite
- Validaciones

Ejecutar pruebas:

```bash
dotnet test
```

---

# 🔹 Parte 7 – Code Review final

Prompt:

```
Perform a senior-level code review on this refactored solution.
Suggest improvements for production readiness.
```

Analizar recomendaciones sobre:

- Logging
- Manejo de excepciones
- Separación por capas
- Inyección de dependencias
- Cobertura de pruebas

---

# 🎓 Preguntas de reflexión

1. ¿Copilot detectó todos los problemas?
2. ¿Fue necesario ajustar los prompts?
3. ¿El código generado cumple buenas prácticas?
4. ¿Qué mejoras adicionales aplicarías manualmente?

---

# 🚀 Extensión opcional (Nivel Avanzado)

Opcional:

```
Refactor this solution to follow Clean Architecture.
```

O:

```
Prepare this code to be used inside an ASP.NET Core Web API.
```

---

# 🔥 Conclusión

En este laboratorio utilizaste GitHub Copilot para:

- Analizar código
- Diseñar mejoras
- Refactorizar arquitectura
- Agregar validaciones
- Generar pruebas
- Realizar revisión técnica

Colaboración avanzada con IA aplicada a modernización real de software.