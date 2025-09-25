using Q10.TaskManager.Infraestructure.Interfaces;
using Q10.TaskManager.Infraestructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddScoped<IConfig, SettingRepository>();
builder.Services.AddScoped<IConfig, EnvironmentRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

var MaxItemsPerPage = app.Configuration["MySettings.MaxItemsPerPage"];

var env1 = app.Configuration["APSNETCORE_ENVIRONMENT"];
var env2 = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

app.Run();
