# Contribuir

Guía rápida para contribuir a `az2007-copilot-labs`.

## Flujo de trabajo sugerido

1. Crear una rama a partir de `main` o la rama objetivo: `feat/descripcion-corta`.
2. Hacer cambios pequeños y atómicos con mensajes de commit claros.
3. Abrir un Pull Request (PR) explicando el propósito y cambios principales.
4. Añadir reviewers y resolver comentarios antes del merge.

## Estilo y buenas prácticas

- Mantener el código simple y legible.
- Seguir convenciones de C#/.NET (nombres PascalCase para clases y métodos).
- No agregar dependencias innecesarias para cambios pequeños.

## Ejecución y pruebas locales

1. Restaurar y compilar:

```powershell
cd src/StoreApi
dotnet restore
dotnet build
```

2. Ejecutar la aplicación localmente:

```powershell
dotnet run
```

## Pull Requests

- Explica el problema que resuelve el PR.
- Incluye pasos para reproducir y verificar los cambios si aplica.
- Añade capturas de pantalla o ejemplos de `curl` si es relevante.

## Código y seguridad

- No incluir credenciales ni secretos en el repositorio.
- Usa variables de entorno o servicios de secret management para claves.

## Contacto

Abrir Issues para discutir mejoras mayores antes de implementarlas.
