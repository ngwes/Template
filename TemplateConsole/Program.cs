using Cocona;
using Microsoft.Extensions.Logging;
using TemplateConsole.Presentation.Installer;

var builder = CoconaApp.CreateBuilder();
builder.Logging.ClearProviders();
builder.Logging.AddConsole();
builder.Logging.AddDebug();
builder.Services.InstallServices(builder.Configuration);
var app = builder.Build();
app.InstallCommandsFromAssembly();
app.Run();