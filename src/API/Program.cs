using API.Data;
using API.Endpoints;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options
	=> options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));

builder.Services.AddCors();

var app = builder.Build();

app.UseHttpsRedirection();

app.UseCors(builder
	=> builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("http://localhost:4200"));

app.RegisterUsersEndpoints();

app.Run();
