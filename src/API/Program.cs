using API.Data;
using API.Endpoints;

using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DataContext>(options
    => options.UseSqlite(builder.Configuration.GetConnectionString("Sqlite")));

var app = builder.Build();

app.UseHttpsRedirection();

app.RegisterUsersEndpoints();

app.Run();
