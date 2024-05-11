using ADSProyect.DB;
using ADSProyect.Interfaces;
using ADSProyect.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//  Configuracion DBContext
builder.Services.AddDbContext<ApplicationDbContext>(opciones => opciones.UseSqlServer("name=DefaultConnection"));


// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//              ADSProject
// Configurando inyecion de dependencias
builder.Services.AddScoped<IEstudiante, EstudianteRepository>();
builder.Services.AddSingleton<ICarrera, CarreraRepository>();
builder.Services.AddSingleton<IProfesor, ProfesorRepository>();
builder.Services.AddSingleton<IGrupo, GrupoRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
