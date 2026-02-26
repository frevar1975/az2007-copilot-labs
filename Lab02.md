# AZ-2007  
# Cuadernillo Completo de Laboratorios  
# Análisis y Documentación de Código con GitHub Copilot

Autor: Freddy Vargas  
Curso: AZ-2007  
Duración estimada: 90 – 120 minutos  

---

# 📌 Introducción

En este laboratorio trabajarás con GitHub Copilot para:

- Analizar un código base desconocido
- Explicar arquitectura y componentes
- Detectar mejoras técnicas
- Generar documentación XML automática
- Crear documentación de proyecto (README)
- Automatizar tareas usando modo Agente
- Generar pruebas unitarias

Proyecto base: ASP.NET Core Web API (.NET 8)

---

# 🛠 Requisitos

- Cuenta GitHub con Copilot habilitado
- Visual Studio Code
- Extensión GitHub Copilot instalada
- .NET SDK 8
- Terminal integrada

Verificar instalación:

```bash
dotnet --version
```

---

# 🔹 FASE 1 – Creación del Proyecto Base

## Paso 1 – Crear la Web API

```bash
dotnet new webapi -n StoreApi
cd StoreApi
code .
```

## Paso 2 – Ejecutar el proyecto

```bash
dotnet run
```

Abrir navegador en:

```
https://localhost:xxxx/swagger
```

Verificar que el endpoint WeatherForecast funciona.

---

# 🔹 FASE 2 – Análisis Inteligente del Código

## Objetivo
Comprender un proyecto desconocido utilizando Copilot.

---

## Paso 1 – Analizar arquitectura completa

Abrir Vista de Chat en modo Preguntar.

Escribir:

```
@workspace Explain the architecture of this project.
```

Observar:

- Estructura general
- Program.cs
- Controladores
- Middleware
- Inyección de dependencias

---

## Paso 2 – Analizar un archivo específico

Abrir:

```
WeatherForecastController.cs
```

Escribir en el chat:

```
Explain the responsibility of this controller.
```

---

## Paso 3 – Analizar bloque seleccionado

Seleccionar el método `Get()` y escribir:

```
/explain
```

Observar:

- Tipo de retorno
- Lógica interna
- Qué datos genera
- Cómo funciona LINQ (si aplica)

---

## Paso 4 – Detectar mejoras

En el chat:

```
How could this controller be improved for production use?
```

Ejemplos esperados:

- Logging estructurado
- Manejo de excepciones
- DTOs
- Validaciones
- Separación en servicios
- Principios SOLID

---

# 🔹 FASE 3 – Documentación Insertada en el Código

## Objetivo
Generar comentarios XML automáticos en clases y métodos.

---

## Paso 1 – Documentar método puntual

Seleccionar el método `Get()` y escribir:

```
/doc
```

Resultado esperado:

```csharp
/// <summary>
/// Retrieves a list of weather forecasts.
/// </summary>
/// <returns>A collection of WeatherForecast objects.</returns>
```

---

## Paso 2 – Documentar clase completa

Seleccionar la clase completa y escribir:

```
Document this class including summary and endpoint description.
```

---

## Paso 3 – Acción Inteligente

1. Seleccionar un método
2. Clic derecho
3. Elegir **Generate Docs**

Copilot insertará la documentación directamente.

---

## Paso 4 – Evaluar calidad

Reflexionar:

- ¿La descripción es clara?
- ¿Explica parámetros correctamente?
- ¿La intención del método está bien descrita?
- ¿Se requiere ajuste manual?

---

# 🔹 FASE 4 – Documentación del Proyecto

## Objetivo
Generar documentación profesional del proyecto.

---

## Paso 1 – Crear README.md

Cambiar el chat a modo Edición.

Escribir:

```
Create a professional README.md file including:
- Project description
- Architecture overview
- Endpoints
- Technologies used
- How to run
```

Revisar cambios sugeridos.
Aceptar.

---

## Paso 2 – Mejorar README

```
Improve the README to follow open source best practices.
```

Agregar:

- Badges
- Estructura clara
- Sección de contribución
- Licencia

---

# 🔹 FASE 5 – Modo Agente (Automatización Completa)

Cambiar chat a modo Agente.

Escribir:

```
Analyze this entire project and generate missing documentation for all public classes and methods.
```

Observar cómo:

- Recorre múltiples archivos
- Inserta documentación automáticamente
- Sugiere mejoras estructurales

---

# 🔹 FASE 6 – Generación de Pruebas Unitarias

Escribir:

```
Generate unit tests for this controller using xUnit.
```

Crear proyecto de pruebas:

```bash
dotnet new xunit -n StoreApi.Tests
```

Copiar pruebas sugeridas.
Agregar referencia al proyecto principal.
Ejecutar:

```bash
dotnet test
```

---

# 🔹 FASE 7 – Refactorización Guiada (Opcional Avanzado)

```
Refactor this controller to follow clean architecture principles.
```

Analizar propuesta:

- Separación en capas
- Servicio Application
- Repository
- Inyección de dependencias
- DTOs

---

# 🔹 Comparativa de Modos de Copilot

| Modo | Uso Ideal | Nivel Automatización |
|------|------------|---------------------|
| Preguntar | Análisis conceptual | Bajo |
| Chat Insertado | Documentación puntual | Medio |
| Edición | Actualizar archivos | Alto |
| Agente | Automatización completa | Muy Alto |

---

# 🔹 Reflexión Final

Responder:

1. ¿Cuándo usarías modo Preguntar?
2. ¿Cuándo usarías modo Edición?
3. ¿Cuándo usarías modo Agente?
4. ¿Copilot reemplaza revisión humana?
5. ¿Qué validarías antes de hacer commit?

---

# 🏁 Resultado Esperado

Al finalizar debes tener:

- Proyecto comprendido
- Código explicado
- Métodos documentados
- README generado
- Pruebas unitarias creadas
- Mejoras arquitectónicas sugeridas

---

# 🚀 Conclusión

GitHub Copilot no solo genera código.

Permite:

- Analizar arquitectura
- Explicar lógica
- Documentar automáticamente
- Automatizar tareas repetitivas
- Mejorar calidad técnica

El desarrollador sigue siendo responsable de validar y decidir.

---

# 🔥 FIN – LABORATORIO COMPLETO AZ-2007