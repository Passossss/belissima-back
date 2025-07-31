
﻿using System.Runtime.CompilerServices;
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
                revendedora.Id = Guid.NewGuid();
                context.Revendedoras.Add(revendedora);
                await context.SaveChangesAsync();
                return revendedora;
            });

            group.MapPut("/{id}", async (Guid id, Revendedora revendedoraAtualizada, AppDbContext db) =>
            {
                if (id != revendedoraAtualizada.Id)
                {
                    return Results.BadRequest("O ID da rota não corresponde ao ID do objeto.");
                }

                var revendedoraExistente = await db.Revendedoras.FindAsync(id);

                if (revendedoraExistente is null)
                {
                    return Results.NotFound("Revendedora não encontrada.");
                }

                revendedoraExistente.Nome = revendedoraAtualizada.Nome;
                revendedoraExistente.Email = revendedoraAtualizada.Email;
                revendedoraExistente.Estado = revendedoraAtualizada.Estado;
                revendedoraExistente.Cidade = revendedoraAtualizada.Cidade;
                revendedoraExistente.Numero = revendedoraAtualizada.Numero;

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            group.MapDelete("/{id}", async (Guid id, AppDbContext db) =>
            {
                var revendedora = await db.Revendedoras.FindAsync(id);

                if (revendedora is null)
                {
                    return Results.NotFound("Revendedora não encontrada.");
                }

                db.Revendedoras.Remove(revendedora);

                await db.SaveChangesAsync();

                return Results.NoContent();
            });

            return app;
        }
    }
}
