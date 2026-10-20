using Banco.Classes.Models.Contextos;
using Microsoft.OpenApi;

var builder = WebApplication.CreateBuilder(args);

// Criação do banco de dados
ContextoConta contexto = new ContextoConta();
contexto.Database.EnsureCreated();

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

// Swagger 
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes =>
{
    opcoes.SwaggerDoc("Versão 1", new Microsoft.OpenApi.OpenApiInfo
    {
        Title = "API para conta bancária do SENAI",
        Version = "Versão 1",
        Description = "API didática para cadastrar contas bancárias com operações CRUD, use os endpoints (rotas) para listar, criar, atualizar e deletar contas.",
        Contact = new Microsoft.OpenApi.OpenApiContact
        {
            Name = "Nicolas",
            Email = "nicolassilvamat@gmail.com",
            Url = new Uri("https://github.com/NicolasSilvaMat17")
        }
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // Swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/Versão 1/swagger.json", "API de contas V1");
        c.DocumentTitle = "Documentação da API de contas do SENAI";
    }
    );
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run(); 
