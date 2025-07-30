using belissima_back.Models;
using System.Runtime.CompilerServices;

namespace belissima_back.Routes
{
    public static class RevendedoraRoutes
    {
        public static IEndpointRouteBuilder MapRevendedoraRoutes(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/Revendedoras").WithTags("Revendedoras");

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
