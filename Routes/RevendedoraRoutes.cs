using belissima_back.Models;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace belissima_back.Routes
{
    public static class RevendedoraRoutes
    {
        public static IEndpointRouteBuilder MapRevendedoraRoutes(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/Revendedoras").WithTags("Revendedoras");


            group.MapGet("/", async (AppDbContext db) =>
                await db.Revendedoras.ToListAsync());

            group.MapGet("/{id}", async (Guid id, AppDbContext db) =>
            {
                var revendedora = await db.Revendedoras.FindAsync(id);
                return revendedora is not null
                    ? Results.Ok(revendedora)
                    : Results.NotFound();
            });

            group.MapPost("", async (Revendedora revendedora, AppDbContext context) =>
            {
                context.Revendedoras.Add(revendedora);
                await context.SaveChangesAsync();
                return revendedora;
            });

            return app;
        }
    }
}
