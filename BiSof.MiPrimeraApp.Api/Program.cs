using BISoft.MiPrimeraApp.Aplicacion.Fabrica;
using MyPrimeraApp.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

var summaries = new[]
{
    "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
};

app.MapGet("/api/Alumnos", () => {

    var service = ServiceFactory.CrearAlumnoService();
    var alumnos = service.ObtenerAlumnos();
    return alumnos;
});
app.MapGet("/api/Maestros", () => {

    var service = ServiceFactory.CrearMaestroService();
    var alumnos = service.ObtenerMaestro();
    return alumnos;
});

app.MapPost("/api/Alumnos", (Alumno alumno) => {

    var service = ServiceFactory.CrearAlumnoService();

    // Asegúrate de que CrearAlumno reciba los tipos correctos
    var resultado = service.CrearAlumno(alumno.Nombre, alumno.Apellido, alumno.Edad.ToString());

    // Asegúrate de que el resultado tenga la propiedad Id
    return  resultado;
});

app.MapPost("/api/Maestros", (Maestro maestro) => {

    var service = ServiceFactory.CrearMaestroService();
  
    // Asegúrate de que CrearAlumno reciba los tipos correctos
    var resultado = service.CrearMaestro(maestro.Nombre, maestro.Apellido, maestro.Direccion,maestro.Email, maestro.Telefono);

    // Asegúrate de que el resultado tenga la propiedad Id
    return resultado;
});

app.MapGet("/weatherforecast", () =>
{
    var forecast = Enumerable.Range(1, 5).Select(index =>
        new WeatherForecast
        (
            DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            Random.Shared.Next(-20, 55),
            summaries[Random.Shared.Next(summaries.Length)]
        ))
        .ToArray();
    return forecast;
})
.WithName("GetWeatherForecast")
.WithOpenApi();

app.Run();

internal record WeatherForecast(DateOnly Date, int TemperatureC, string? Summary)
{
    public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);
}
