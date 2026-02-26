# 🧪 Laboratorio: Examen de Configuración y Características de GitHub Copilot en VS Code

---

## 🎯 Objetivo del Laboratorio

En este laboratorio examinarás:

- La configuración de GitHub Copilot en Visual Studio Code.
- Las herramientas disponibles para el Agent.
- Los modos de interacción: **Ask, Plan y Agent**.
- La ejecución práctica de acciones sobre un proyecto .NET.

Al finalizar, habrás validado tanto la configuración como el uso funcional de Copilot.

---

## 🔹 Prerrequisitos

- Cuenta de GitHub con Copilot habilitado.
- Visual Studio Code actualizado.
- Extensión GitHub Copilot instalada.
- Proyecto .NET abierto (ej: `StoreApi`).
- Terminal funcional con .NET SDK instalado.

---

# 🔹 Parte 1 – Examen de Configuración

## 1️⃣ Abrir vista de Chat

Presiona:

```
Ctrl + Shift + I
```

Verifica que se abra la vista con las opciones:

- Agent
- Ask
- Plan

---

## 2️⃣ Verificar modelo activo

En la parte inferior del chat valida:

- Modelo seleccionado (ej: GPT-5 mini).
- Agente activo (ej: Default Agent o AIAgentExpert).

---

## 3️⃣ Revisar herramientas habilitadas

Haz clic en:

```
Configure Tools
```

Verifica que estén activadas las siguientes herramientas:

- read (Leer archivos)
- edit (Modificar archivos)
- execute (Ejecutar comandos)
- search (Buscar en proyecto)
- web (Consultar internet)
- todo (Opcional)

### Preguntas de análisis

- ¿Qué herramienta permite modificar archivos?
- ¿Cuál permite ejecutar comandos locales?
- ¿Qué ocurre si se desactiva "execute"?

---

# 🔹 Parte 2 – Uso del modo Ask

## 🎯 Objetivo

Usar Copilot para analizar código sin modificarlo.

### Paso

En el chat escribe:

```
Explain what Program.cs does in this project.
```

### Validar

- ¿Describe correctamente el pipeline?
- ¿Identifica servicios configurados?
- ¿Menciona middlewares?

---

# 🔹 Parte 3 – Uso del modo Plan

## 🎯 Objetivo

Solicitar planificación antes de ejecutar cambios.

### Paso

En el chat escribe:

```
Plan how to add structured logging to this API.
```

### Validar

- ¿Propone pasos claros?
- ¿Sugiere paquetes o configuraciones?
- ¿Explica dónde modificar el código?

⚠ No ejecutar todavía los cambios.

---

# 🔹 Parte 4 – Uso del modo Agent

## 🎯 Objetivo

Permitir que el agente ejecute acciones reales.

### Paso

En el chat escribe:

```
Implement structured logging in this project using ILogger.
```

### Validar

- ¿Modifica archivos?
- ¿Agrega using necesarios?
- ¿Inyecta ILogger?
- ¿Configura builder.Logging?

---

# 🔹 Parte 5 – Ejecución de comandos

Si la herramienta `execute` está habilitada, escribe:

```
Run the project to verify it builds correctly.
```

### Validar

- ¿Ejecuta dotnet run?
- ¿Muestra salida en terminal?
- ¿Compila sin errores?

---

# 🔹 Parte 6 – Prueba de Gobernanza

## 🎯 Objetivo

Demostrar control sobre capacidades del agente.

1. Ir a `Configure Tools`
2. Desactivar `execute`
3. Intentar nuevamente:

```
Run the project again.
```

### Resultado esperado

El agente no puede ejecutar comandos.

### Conclusión

El usuario controla qué herramientas puede usar el agente.

---

# 🔹 Parte 7 – Reflexión Técnica

Responder:

1. ¿Cuál es la diferencia entre Ask y Agent?
2. ¿Cuándo conviene usar Plan?
3. ¿Qué riesgos existen si se habilita execute sin control?
4. ¿Cómo impacta esto en entornos empresariales?

---

# ✅ Criterios de Aprobación

☑ Se revisó configuración  
☑ Se validaron herramientas  
☑ Se utilizó Ask correctamente  
☑ Se utilizó Plan correctamente  
☑ Se utilizó Agent correctamente  
☑ Se probó control de herramientas  

---

# 🧠 Conclusión

GitHub Copilot opera como un sistema basado en agentes con herramientas configurables.

El usuario define el nivel de autonomía y capacidad de ejecución, lo que permite adaptarlo a distintos entornos: desarrollo personal, equipos empresariales o escenarios con gobernanza estricta.

---
