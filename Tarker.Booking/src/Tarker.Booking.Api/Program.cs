using Tarker.Booking.Api;
using Tarker.Booking.Application;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;

// 1. Crea un objeto WebApplicationBuilder que se utiliza para configurar
// y construir la aplicación web.
var builder = WebApplication.CreateBuilder(args);

// 1. Aquí se agregan los servicios de inyección de dependencias cuando
// inician la aplicación.
builder.Services
    .AddWebApi()
    .AddAddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

// 1. builder.Build() crea la instancia de WebApplication.
var app = builder.Build();

// 1. Inicia la aplicación web y comienza a procesar las solicitudes entrantes.
app.Run();
