using DiogoStocco.Models;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();
var app = builder.Build();

app.MapPost("/api/funcionario/cadastrar", ([FromBody] Funcionario funcionarios,
    [FromServices] AppDataContext ctx) =>
{
    ctx.Funcionarios.Add(funcionarios);
    ctx.SaveChanges();
    return Results.Created("", funcionarios);
});

app.MapGet("/api/funcionario/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Funcionarios.Any())
    {
        return Results.Ok(ctx.Funcionarios.ToList());
    }
    return Results.NotFound();
});

app.Run();