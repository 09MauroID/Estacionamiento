using Presentacion.Persistencia;
using Microsoft.EntityFrameworkCore;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//obtengo el connectionString desde el archivo appsettings.json
//se debe indicar el nombre del item "proyecto_db"
var connectionString = builder.Configuration.GetConnectionString("proyecto_db");

//agrego la configuracion al nuestro contexto AplicacionDbContexto
builder.Services.AddDbContext<PresentacionDbContext>(opcion =>
    opcion.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30))));

//agrego nuestro context AplicacionDbContext al contenedor de objetos
//con esto el objeto va a ser poder accedido desde cualquier otro objeto
//particularmente los controladores
builder.Services.AddDbContext<PresentacionDbContext>();

//Por defecto, la accion de crear el objeto contexto no significa que se creara la base de datos 
//en MySql, por lo que lo debemos hacer manualmente

//creo un objeto de opciones de nuestro contexto
var opciones = new DbContextOptionsBuilder<PresentacionDbContext>();

//a las opciones creadas le asigno las credenciales para conectar la base de datos
opciones.UseMySql(connectionString, new MySqlServerVersion(new Version(8, 0, 30)));

//creo un objeto contexto con las opciones previamente definidas
var contexto = new PresentacionDbContext(opciones.Options);

//indico explicitamente que se debe crear nuestro contexto en el motor de base de datos
contexto.Database.EnsureCreated();

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
