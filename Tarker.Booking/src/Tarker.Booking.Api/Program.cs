using Microsoft.EntityFrameworkCore;
using Tarker.Booking.Application.Interfaces;
using Tarker.Booking.Persistence.DataBase;

var builder = WebApplication.CreateBuilder(args);

// 1. Método que registrar DataBaseService como un servicio de DbContext
// en el contenedor de inyección de dependencias.
// 2. option.UseSqlServer configura EntityFramework Core para usar SQL.
// 3. builder.Configuration[] obtiene la cadena de conexión de la configuración
// de la aplicación. Ejemplo, appsettings.json.
builder.Services.AddDbContext<DataBaseService>(option =>
option.UseSqlServer(builder.Configuration["SQLConnectionStrings"]));

// 1. Método de AddScope registra IDataBaseService y DataBaseService en el
// contenedor de inyección de dependencias.
// 2. IDataService es una interfaz y DataBaseService es su implementación concreta.
// 3. AddScope indica que una nueva instancia del servicio se creará una vez por solicitud.
// NOTA: Se puede crear mas interfaces con el nombre de su servicio.
builder.Services.AddScoped<IDataBaseService, DataBaseService>();

// 1. builder.Build() crea la instancia de WebApplication.
var app = builder.Build();

// 1. Inicia la aplicación web y comienza a procesar las solicitudes entrantes.
app.Run();
