# 🎓 AZ-2007 – LAB 04
# Testing Profesional con GitHub Copilot (Modo Preguntar, Edición y Agente)

---

## 🎯 Objetivo del laboratorio

En este laboratorio aprenderás a utilizar GitHub Copilot para:

- Analizar código antes de crear pruebas
- Diseñar estrategia de testing
- Generar pruebas unitarias
- Refinar pruebas con instrucciones específicas
- Automatizar configuración del entorno de pruebas
- Evaluar cobertura y calidad

Este laboratorio parte completamente desde cero.

---

## ⏱ Duración estimada

| Actividad | Tiempo |
|------------|--------|
| Setup inicial | 5 min |
| Análisis con modo Preguntar | 5 min |
| Generate Tests | 5 min |
| Chat insertado avanzado | 10 min |
| Modo Edición (estructura) | 5 min |
| Modo Agente (automatización) | 5 min |
| Cobertura y mejora | 10 min |

Duración total aproximada: 45 minutos

---

# 🔹 Paso 1 – Crear proyecto base

En consola:

```bash
dotnet new console -n PaymentProcessorLab
cd PaymentProcessorLab
code .
```

---

# 🔹 Paso 2 – Crear lógica de negocio

Reemplaza el contenido de `Program.cs` por:

```csharp
using System;

public class PaymentService
{
    public decimal CalculateFinalAmount(decimal amount, string customerType)
    {
        if (amount <= 0)
            throw new ArgumentException("Amount must be greater than zero");

        decimal discount = 0;

        if (customerType == "VIP")
            discount = 0.15m;

        if (customerType == "Employee")
            discount = 0.30m;

        decimal finalAmount = amount - (amount * discount);

        if (finalAmount > 1000)
            finalAmount -= 100;

        return finalAmount;
    }
}

class Program
{
    static void Main()
    {
        var service = new PaymentService();
        Console.WriteLine(service.CalculateFinalAmount(1500, "VIP"));
    }
}
```

Ejecutar:

```bash
dotnet run
```

---

# 🔹 Parte 1 – Modo Preguntar (Análisis)

Abrir Vista de Chat → Modo Preguntar.

Prompt:

```
Analyze this PaymentService class and suggest a unit testing strategy.
List scenarios and edge cases that should be covered.
```

Identificar:

- amount <= 0
- VIP discount
- Employee discount
- No discount case
- Bulk discount (>1000)
- Combinación descuento + bulk
- Valores límite

---

# 🔹 Parte 2 – Crear proyecto de pruebas

En consola:

```bash
dotnet new xunit -n PaymentProcessorLab.Tests
dotnet add PaymentProcessorLab.Tests reference PaymentProcessorLab
```

---

# 🔹 Parte 3 – Acción Inteligente “Generate Tests”

Ir a `PaymentService`.

Clic derecho → Generate Tests.

Revisar las pruebas generadas.

Ejecutar:

```bash
dotnet test
```

---

# 🔹 Parte 4 – Mejorar pruebas con Chat Insertado

Abrir el archivo de test.

Seleccionar método principal.

Abrir Chat Insertado (Ctrl + I).

Prompt:

```
Improve these tests:
- Cover edge cases
- Add negative amount scenario
- Verify bulk discount logic
- Follow Arrange-Act-Assert pattern
```

Revisar sugerencias.

Aceptar o ajustar manualmente.

---

# 🔹 Parte 5 – Usar Modo Edición

Abrir Vista de Chat → Modo Edición.

Prompt:

```
Refactor the tests to use [Theory] with InlineData instead of repeating similar test cases.
```

Verificar que se generen pruebas parametrizadas.

---

# 🔹 Parte 6 – Usar Modo Agente

Vista de Chat → Modo Agente.

Prompt:

```
Organize the test project into folders:
- Services
Move PaymentService tests into Services folder.
Ensure namespaces are updated correctly.
```

Revisar cambios sugeridos antes de aceptar.

---

# 🔹 Parte 7 – Evaluar Cobertura

En consola:

```bash
dotnet test --collect:"XPlat Code Coverage"
```

Luego preguntar en Chat:

```
Based on the existing tests, what scenarios might still be missing?
```

Agregar pruebas adicionales si es necesario.

---

# 🔹 Parte 8 – Romper el código intencionalmente

Modificar lógica:

Cambiar:

```csharp
discount = 0.15m;
```

por:

```csharp
discount = 0.10m;
```

Ejecutar:

```bash
dotnet test
```

Verificar que las pruebas fallen.

---

# 🔹 Parte 9 – Code Review de pruebas

Modo Preguntar:

```
Perform a senior-level review of these unit tests.
Are they production-ready?
```

Evaluar:

- Claridad
- Cobertura
- Casos límite
- Robustez de asserts

---

# 🎓 Preguntas de reflexión

1. ¿Generate Tests cubrió todos los escenarios?
2. ¿El chat insertado mejoró la calidad?
3. ¿Modo Agente fue útil o excesivo?
4. ¿Qué errores pudo haber introducido Copilot?

---

# 🏆 Objetivo alcanzado

En este laboratorio utilizaste:

- Modo Preguntar (análisis)
- Generate Tests (automatización básica)
- Chat Insertado (control fino)
- Modo Edición (refactor)
- Modo Agente (automatización estructural)
- Cobertura y validación

Testing profesional asistido por IA.