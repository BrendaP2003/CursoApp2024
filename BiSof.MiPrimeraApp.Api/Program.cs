using BISoft.MiPrimeraApp.Aplicacion.Fabrica;
using BISoft.MiPrimeraApp.Aplicacion.Request;
using BISoft.MiPrimeraApp.Aplicacion.Response;
using BISoft.MiPrimeraApp.Aplicacion.Servicios;
using Microsoft.EntityFrameworkCore;
using MyPrimeraApp.Contextos;
using MyPrimeraApp.Entidades;
using MyPrimeraApp.Repositorio;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.



// Configurar el contexto de la base de datos
builder.Services.AddDbContext<Context>(options =>
    options.UseSqlServer("server=lap-brendap\\SQLEXPRESS;database = Escuela;Encrypt=false; Trusted_connection=true")
);

builder.Services.AddScoped<AlumnoService>();
builder.Services.AddScoped<IAlumnoRepository, AlumnoRepository>();

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



//app.MapGet("/api/Alumnos/{id}", (int id) => {

//    //var service = ServiceFactory.CrearAlumnoService();
//    var alumnos = service.ObtenerAlumnos();
//    return alumnos;
//});

//inveatigar recuest scoud, sigleton y tracher

app.MapGet("/api/alumnos", (AlumnoService service) =>
{
   // var service = ServiceFactory.CrearAlumnoService();
    var alumnos = service.ObtenerAlumnos();
    return alumnos;
});

app.MapPost("/api/alumnos", (AlumnoService service, CrearAlumno alumnoDto) =>
{
    var alumno = service.CrearAlumno(alumnoDto.Nombre, alumnoDto.Apellido, alumnoDto.Email);
    return alumno;
});

app.MapGet("/api/Maestros", () => {

    var service = ServiceFactory.CrearMaestroService();
    var alumnos = service.ObtenerMaestro();
    return alumnos;
});

//app.MapPost("/api/Alumnos", (Alumno alumno) => {

//    var service = ServiceFactory.CrearAlumnoService();
//    var resultado = service.CrearAlumno(alumno.Nombre, alumno.Apellido, alumno.Email);

    
//    return  resultado;
//});

app.MapPost("/api/Maestros/", (Maestro maestro) => {

    var service = ServiceFactory.CrearMaestroService();
    var resultado = service.CrearMaestro(maestro.Nombre, maestro.Apellido, maestro.Direccion,maestro.Email, maestro.Telefono);

    
    return resultado;
});



app.Run();

