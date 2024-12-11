using API.models;
using API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<AppDataContext>();


builder.Services.AddCors(options =>
    options.AddPolicy("Acesso Total",
        configs => configs
            .AllowAnyOrigin()
            .AllowAnyHeader()
            .AllowAnyMethod())
);

var app = builder.Build();


app.MapGet("/", () => "Alunos/Imcs");


app.MapGet("api/aluno/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Alunos.Any())
    {
        return Results.Ok(ctx.Alunos.ToList());
    }
    return Results.NotFound("Nenhum aluno encontrado");
});


app.MapPost("api/aluno/cadastrar", ([FromServices] AppDataContext ctx, [FromBody] Aluno aluno) =>
{
    ctx.Alunos.Add(aluno);
    ctx.SaveChanges();
    return Results.Created("", aluno);
});


app.MapGet("api/imc/listar", ([FromServices] AppDataContext ctx) =>
{
    if (ctx.Imcs.Any())
    {
        return Results.Ok(ctx.Imcs.ToList());
    }
    return Results.NotFound("Nenhum imc encontrado");
});


app.MapPost("api/imc/cadastrar", ([FromServices] AppDataContext ctx, [FromBody] Imc imc) =>
{
    Aluno? aluno = ctx.Alunos.Find(imc.AlunoId);
    if (aluno == null)
    {
        return Results.NotFound("Aluno não encontrado");
    }
    imc.Aluno = aluno;
    ctx.Imcs.Add(imc);
    ctx.SaveChanges();
    return Results.Created("", imc);
}); 


/*app.MapPut("api/imc/alterar/{Nome}", ([FromServices] AppDataContext ctx, [FromRoute] string Nome) =>
{
  
    Imc? imc = ctx.Imcs.Find(Nome);
    if (imc is null)
    {
        return Results.NotFound("Aluno não encontrado");
    }

    if (imc.Status == "Não iniciada")
    {
        tarefa.Status = "Em andamento";
    }
    else if (tarefa.Status == "Em andamento")
    {
        tarefa.Status = "Concluída";
    }

    ctx.Tarefas.Update(tarefa);
    ctx.SaveChanges();
    return Results.Ok(ctx.Tarefas.ToList());
}); */



app.UseCors("Acesso Total");
app.Run();


