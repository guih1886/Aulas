using Freelando.Dados.UnitOfWork;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Freelando.Api.Endpoints;
public static class PropostasExtensions
{
    public static void AddEndPointPropostas(this WebApplication app)
    {
        app.MapGet("/propostas", async ([FromServices] IUnitOfWork unitOfWork) =>
        {
            var proposta = await unitOfWork.contexto.Propostas.FromSqlRaw("EXEC sp_BuscarTodasPropostas").ToListAsync();

            return Results.Ok(proposta);

        }).WithTags("Propostas").WithOpenApi();

        app.MapGet("/propostas/projeto", async ([FromServices] IUnitOfWork unitOfWork, [FromQuery] Guid id_projeto) =>
        {
            SqlParameter[] parametros =
            {
                new SqlParameter("@id_projeto", id_projeto)
            };

            var proposta = await unitOfWork.contexto.Propostas.FromSqlRaw("EXEC sp_PropostaPorProjeto", parametros).ToListAsync();

            return Results.Ok(proposta);

        }).WithTags("Propostas").WithOpenApi();

        app.MapGet("/propostas/summary", async ([FromServices] IUnitOfWork unitOfWork) =>
        {
            var proposta = await unitOfWork.contexto.Database.SqlQueryRaw<PropostaSummary>("EXEC sp_PropostaPorProjeto").ToListAsync();

            return Results.Ok(proposta);

        }).WithTags("Propostas").WithOpenApi();



    }

    public class PropostaSummary
    {
        public Guid Id_Proposta { get; set; }
        public DateTime Data_Proposta { get; set; }
        public DateTime Prazo_Entrega { get; set; }
    }
}


