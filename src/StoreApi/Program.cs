// Crea el builder de la aplicación web. `args` viene de la línea de comandos.
var builder = WebApplication.CreateBuilder(args);

// Añadimos servicios al contenedor de inyección de dependencias.
// - AddEndpointsApiExplorer: ayuda a descubrir los endpoints para OpenAPI/Swagger.
// - AddSwaggerGen: registra el generador de documentación Swagger/OpenAPI (Swashbuckle).
//   Esto no expone la UI por sí solo; configura la generación del documento.
// Más información: https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Construye la aplicación (crea el pipeline a partir de la configuración y servicios registrados).
var app = builder.Build();

// Configuración del pipeline HTTP.
// En desarrollo habilitamos Swagger y la UI interactiva para explorar y probar la API.
// En entornos de producción normalmente no expones la UI sin protección.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();    // Genera el documento OpenAPI en /swagger/v1/swagger.json
    app.UseSwaggerUI();  // Proporciona la interfaz web interactiva en /swagger
}

// Si quieres forzar HTTPS, descomenta la siguiente línea. Está comentada en este demo.
// app.UseHttpsRedirection();

// Datos de ejemplo que usa el endpoint de demo (resumenes del tiempo).
var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

// Define un endpoint HTTP GET en la ruta /weatherforecast.
// Usa la sintaxis "minimal APIs" de .NET 6+ que permite mapear lambdas a rutas.
app.MapGet("/weatherforecast", () =>
{
    // Crea un arreglo de 5 pronósticos ficticios, uno por día.
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            // Fecha: hoy + index días
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            // Temperatura en C: valor aleatorio entre -20 y 54
            Random.Shared.Next(-20, 55),
            // Resumen: elige aleatoriamente de la lista `summaries`
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();

    // Devuelve el array; el framework lo serializará a JSON automáticamente.
    return forecast;
})
// Con `.WithName` damos un nombre al endpoint (útil para rutas y documentación).
.WithName("GetWeatherForecast")
// `.WithOpenApi()` indica que este endpoint debe incluirse en el documento OpenAPI generado.
.WithOpenApi();

// Inicia la aplicación y comienza a escuchar peticiones HTTP.
app.Run();

// Definición de un tipo inmutable (record) que representa un pronóstico del tiempo.
// - `DateOnly` almacena la fecha (sin hora).
// - `TemperatureC` temperatura en Celsius.
// - `Summary` texto opcional que describe el clima.
// Además expone una propiedad calculada `TemperatureF` para convertir a Fahrenheit.
record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    // Propiedad calculada: conversión simple de Celsius a Fahrenheit.
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
