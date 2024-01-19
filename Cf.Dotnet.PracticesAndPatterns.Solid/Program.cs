using Cf.Dotnet.PracticesAndPatterns.Solid.Application;
using Cf.Dotnet.PracticesAndPatterns.Solid.Data;
using Cf.Dotnet.PracticesAndPatterns.Solid.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;

// Creando el constructor de la aplicación host.
var builder = Host.CreateApplicationBuilder(args);

// Configurando el logging para que utilice la consola.
builder.Logging.AddConsole();

// Configurando los servicios de la aplicación.
builder.Services.AddDbContext<DatabaseContext>(cfg => cfg.UseInMemoryDatabase(nameof(DatabaseContext))); 
builder.Services.AddTransient<NotificationService, NotificationService>(); 
builder.Services.AddTransient<IUserCreateService, UserCreateService>(); 
builder.Services.AddTransient<IUserApplication, UserApplication>(); 

// Construyendo el host de la aplicación.
using var host = builder.Build();

// Obteniendo la instancia de IUserApplication desde el contenedor de servicios.
var application = host.Services.GetRequiredService<IUserApplication>();
var logger = host.Services.GetRequiredService<ILogger<Program>>();

// Creando un usuario a través de la aplicación.
var user = application.CreateUser("Jerome");
logger.LogInformation("User name: {UserName}", user.Name);