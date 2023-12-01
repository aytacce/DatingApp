using API.Data;

using Microsoft.EntityFrameworkCore;

namespace API.Endpoints;

public static class UsersEndpoints
{
    public static void RegisterUsersEndpoints(this WebApplication app)
    {
        var group = app.MapGroup("/users");

        group.MapGet("/", async (DataContext dataContext) => await dataContext.Users.ToListAsync());

        group.MapGet("/{id}", async (int id, DataContext dataContext) => await dataContext.Users.FindAsync(id));
    }
}
