
﻿using System.Runtime.CompilerServices;
using belissima_back.Models;
using Microsoft.EntityFrameworkCore;


namespace belissima_back.Routes
{
    public static class RevendedoraRoutes
    {
        public static IEndpointRouteBuilder MapRevendedoraRoutes(this IEndpointRouteBuilder app)
        {
            var group = app.MapGroup("api/Revendedoras").WithTags("Revendedoras");


            group.MapGet("/", async (AppDbContext db) =>
            await db.Revendedoras.ToListAsync());

            group.MapGet("/{id}", async (int id, AppDbContext db) =>
            await db.Revendedoras.FindAsync(id) is Revendedora revendedora
                ? Results.Ok(revendedora)
                : Results.NotFound());

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
