# AZ-2007 | Laboratorio Completo – GitHub Copilot con .NET 8 Web API

## 🎯 Objetivo

En este laboratorio practicarás cómo usar GitHub Copilot en escenarios reales con una API en .NET 8:

1. Responder preguntas técnicas
2. Explicar y documentar código existente
3. Detectar y corregir errores
4. Generar nuevas funcionalidades
5. Generar pruebas unitarias
6. Refactorizar código
7. Revisar código y sugerir mejoras

---

# 🔹 0️⃣ Preparación Inicial

## 0.1 Verificar .NET instalado

```powershell
dotnet --list-sdks
```

Debe aparecer una versión 8.x.

---

## 0.2 Crear el proyecto (si no existe)

```powershell
mkdir az2007-copilot-labs
cd az2007-copilot-labs

dotnet new sln -n az2007-copilot-labs
mkdir src

dotnet new webapi -n StoreApi -o src/StoreApi --framework net8.0
dotnet sln add src/StoreApi/StoreApi.csproj
```

---

## 0.3 Ejecutar la API

```powershell
dotnet run --project src/StoreApi/StoreApi.csproj
```

Abrir en el navegador:

```
http://localhost:5040/swagger
```

Deberías ver el endpoint `/weatherforecast`.

---

# 1️⃣ Responder preguntas técnicas

Abre GitHub Copilot Chat (Quick Chat o Chat View) y escribe:

```
¿Qué es Swagger/OpenAPI en ASP.NET Core y para qué se usa?
```

Observa cómo Copilot responde con explicación técnica contextual.

---

# 2️⃣ Explicar y documentar código existente

Abre el archivo:

```
src/StoreApi/Program.cs
```

En Copilot Chat escribe:

```
Explícame este Program.cs paso a paso y agrega comentarios útiles sin cambiar la lógica.
```

Aplica los comentarios sugeridos si son correctos.

---

# 3️⃣ Detectar y corregir un error

## 3.1 Provocar el error

En `Program.cs`, busca esta línea:

```csharp
summaries[Random.Shared.Next(summaries.Length)]
```

Cámbiala por:

```csharp
summaries[Random.Shared.Next(summaries.Length + 5)]
```

Guarda el archivo.

---

## 3.2 Probar el error

Ejecuta nuevamente:

```powershell
dotnet run --project src/StoreApi/StoreApi.csproj
```

En Swagger ejecuta:

GET `/weatherforecast`

Deberías obtener:

- 500 Internal Server Error  
- IndexOutOfRangeException  

---

## 3.3 Pedir a Copilot que lo corrija

Selecciona la línea incorrecta y usa Inline Chat con:

```
Este endpoint lanza un IndexOutOfRangeException.
Corrígelo usando buenas prácticas y explica por qué ocurre.
```

Aplica el cambio sugerido (volver a `summaries.Length`).

Vuelve a probar en Swagger → debe responder 200 OK.

---

# 4️⃣ Generar nuevas funcionalidades

Vamos a crear un CRUD mínimo en memoria.

Coloca el cursor debajo del endpoint `/weatherforecast` y usa Inline Chat con:

```
Agrega endpoints mínimos para Products en memoria:

- GET /api/products
- GET /api/products/{id}
- POST /api/products

Usa record Product(int Id, string Name, decimal Price).
Sin base de datos.
Manténlo simple.
```

Acepta el código generado.

---

## Probar en Swagger

Ejecuta:

```powershell
dotnet run --project src/StoreApi/StoreApi.csproj
```

En Swagger deberías ver:

- GET /api/products
- GET /api/products/{id}
- POST /api/products

Prueba cada uno.

---

# 5️⃣ Generar pruebas unitarias

## 5.1 Crear proyecto de pruebas

```powershell
dotnet new xunit -n StoreApi.Tests -o src/StoreApi.Tests --framework net8.0
dotnet add src/StoreApi.Tests/StoreApi.Tests.csproj reference src/StoreApi/StoreApi.csproj
dotnet sln add src/StoreApi.Tests/StoreApi.Tests.csproj
```

---

## 5.2 Pedir pruebas a Copilot

En Copilot Chat escribe:

```
Genera pruebas xUnit para:

- GET /api/products devuelve lista
- GET /api/products/{id} devuelve 404 si no existe
- POST /api/products crea un producto correctamente
Dame el archivo completo.
```

Copia el código generado en el proyecto de tests.

---

## 5.3 Ejecutar pruebas

```powershell
dotnet test
```

Verifica que los tests se ejecuten correctamente.

---

# 6️⃣ Refactorizar código

Selecciona el bloque de endpoints de Products y usa Inline Chat:

```
Refactoriza moviendo la lógica a un ProductService en un archivo nuevo.
Deja Program.cs más limpio.
Manténlo simple.
```

Aplica los cambios sugeridos.

---

# 7️⃣ Revisión de código

En Copilot Chat escribe:

```
Haz una revisión de código como desarrollador senior.
Sugiere mejoras en diseño, validación, legibilidad y seguridad básica.
Devuélveme una lista priorizada.
```

Aplica algunas mejoras sugeridas.

---

# ✅ Checklist Final

- [ ] Ejecuté la API y abrí Swagger  
- [ ] Hice una pregunta técnica a Copilot  
- [ ] Copilot explicó el archivo Program.cs  
- [ ] Provocé un error y Copilot lo corrigió  
- [ ] Copilot generó endpoints nuevos  
- [ ] Generé pruebas unitarias con Copilot  
- [ ] Refactoricé el código  
- [ ] Realicé una revisión de código con Copilot  

---

## 🏁 Conclusión

En este laboratorio utilizaste GitHub Copilot como:

- Asistente técnico
- Documentador
- Detector de errores
- Generador de funcionalidades
- Generador de pruebas
- Refactorizador
- Revisor de código

Copilot acelera el desarrollo y mejora la calidad del código cuando se usa correctamente.