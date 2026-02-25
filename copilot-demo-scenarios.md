# GitHub Copilot – Demo de Escenarios de Asistencia IA (.NET 8 Web API)

## Objetivo
Demostrar cómo GitHub Copilot asiste al desarrollador en escenarios reales de desarrollo utilizando un proyecto ASP.NET Core Web API (.NET 8).

---

# 1️⃣ Responder preguntas sobre lenguajes, herramientas y tecnologías

## Qué demostrar
Copilot como asistente de conocimiento técnico.

## UI recomendada
✔ Chat rápido (Quick Chat)

## Prompt sugerido
> ¿Qué es una ASP.NET Core Web API en .NET 8 y cuál es la diferencia entre Minimal APIs y Controllers?

## Qué decir en clase
- Copilot no solo genera código.
- También responde dudas técnicas.
- Funciona como asistente contextual dentro del IDE.

---

# 2️⃣ Explicar y documentar el código existente

## Qué demostrar
Copilot entiende el código actual y lo puede explicar o documentar.

## UI recomendada
✔ Vista de chat (Chat View)

## Acción
Abrir `Program.cs`

## Prompt sugerido
> Explícame este archivo Program.cs como si fuera para un alumno principiante y agrega comentarios útiles sin cambiar la lógica.

## Qué decir en clase
- Copilot analiza el código completo.
- Puede explicar arquitectura, flujo y responsabilidades.
- Útil para onboarding y documentación rápida.

---

# 3️⃣ Proponer correcciones de error o técnicas alternativas

## Qué demostrar
Copilot ayuda a corregir errores y mejorar lógica.

## UI recomendada
✔ Acciones inteligentes (Smart Actions)  
✔ Chat insertado (Inline Chat)

## Acción
Provocar un pequeño error, por ejemplo:
- Usar `First()` en vez de `FirstOrDefault()`.

## Prompt sugerido (si usas chat)
> Este endpoint falla cuando el ID no existe. Corrige el problema y explica por qué ocurre.

## Qué decir en clase
- Copilot detecta patrones problemáticos.
- Sugiere mejores prácticas.
- Puede explicar el motivo del error.

---

# 4️⃣ Generar nuevas características de código

## Qué demostrar
Copilot genera endpoints, clases o bloques completos.

## UI recomendada
✔ Chat insertado (Inline Chat)

## Prompt sugerido
> Agrega endpoints mínimos para Products en memoria:
> - GET /api/products
> - GET /api/products/{id}
> - POST /api/products
> Usa record Product(int Id, string Name, decimal Price). Sin base de datos.

## Qué decir en clase
- Copilot genera código funcional.
- No es solo autocompletado.
- Acelera el desarrollo inicial.

---

# 5️⃣ Generar casos de prueba unitaria

## Qué demostrar
Copilot crea pruebas automatizadas.

## UI recomendada
✔ Vista de chat (Chat View)

## Prompt sugerido
> Genera pruebas unitarias con xUnit para validar:
> - Obtener lista de productos
> - Obtener producto inexistente devuelve 404
> - Crear producto correctamente

## Qué decir en clase
- Copilot entiende la intención funcional.
- Puede crear pruebas consistentes.
- Aumenta calidad y cobertura rápidamente.

---

# 6️⃣ Refactorizar código existente y sugerir mejoras

## Qué demostrar
Copilot mejora estructura y diseño.

## UI recomendada
✔ Chat insertado (Inline Chat)

## Acción
Seleccionar bloque de endpoints.

## Prompt sugerido
> Refactoriza este código moviendo la lógica a un ProductService. Mantén Program.cs limpio y simple.

## Qué decir en clase
- Copilot ayuda a aplicar buenas prácticas.
- Puede separar responsabilidades.
- Útil para mejorar mantenibilidad.

---

# 7️⃣ Revisar el código y sugerir actualizaciones

## Qué demostrar
Copilot como herramienta de code review.

## UI recomendada
✔ Vista de chat (Chat View)

## Prompt sugerido
> Realiza una revisión de código como desarrollador senior. Indica mejoras en legibilidad, validaciones, seguridad y diseño.

## Qué decir en clase
- Copilot detecta mejoras estructurales.
- Sugiere validaciones adicionales.
- Funciona como asistente de revisión.

---

# Resumen Final

En esta demo vimos cómo GitHub Copilot puede:

✔ Responder preguntas técnicas  
✔ Explicar código  
✔ Corregir errores  
✔ Generar nuevas funcionalidades  
✔ Crear pruebas unitarias  
✔ Refactorizar  
✔ Realizar revisiones de código  

Copilot no reemplaza al desarrollador.  
Funciona como un **copiloto que acelera y apoya la toma de decisiones técnicas.**