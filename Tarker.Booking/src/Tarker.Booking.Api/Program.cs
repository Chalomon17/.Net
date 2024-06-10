using Tarker.Booking.Api;
using Tarker.Booking.Application;
using Tarker.Booking.Common;
using Tarker.Booking.External;
using Tarker.Booking.Persistence;

// 1. Crea un objeto WebApplicationBuilder que se utiliza para configurar
// y construir la aplicaci�n web.
var builder = WebApplication.CreateBuilder(args);

// 1. Aqu� se agregan los servicios de inyecci�n de dependencias cuando
// inician la aplicaci�n.
builder.Services
    .AddWebApi()
    .AddAddCommon()
    .AddApplication()
    .AddExternal(builder.Configuration)
    .AddPersistence(builder.Configuration);

// 1. builder.Build() crea la instancia de WebApplication.
var app = builder.Build();

// 1. Inicia la aplicaci�n web y comienza a procesar las solicitudes entrantes.
app.Run();
