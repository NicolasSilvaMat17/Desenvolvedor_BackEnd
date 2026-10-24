using CasasBahia.Classes.Models.Contextos;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Conectar Banco de Dados
ContextoLogin contexto = new ContextoLogin();
contexto.Database.EnsureCreated();
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(opcoes =>
    opcoes.SwaggerDoc("v1", new Microsoft.OpenApi.OpenApiInfo
    {
        Title = "API para as lojas Casas Bahia",
        Version = "v1",
        Description = "API didatica para realizar operações de CRUD em banco de dados sql, use os endpoints(rotas) para listar, criar, atualizar e excluir registros, produtos e vendas.",

    }

    )
    
);
builder.Services.AddSwaggerGen(opcoes =>
    {
        var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
        var xmlCaminho = Path.Combine(AppContext.BaseDirectory, xmlFile);
        opcoes.IncludeXmlComments(xmlCaminho);

    }
);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
    // Swagger
    app.UseSwagger();
    app.UseSwaggerUI(c =>
    {
        c.SwaggerEndpoint("/swagger/v1/swagger.json", "API para as lojas Casas Bahia");
        c.DocumentTitle = "Documentação da API didática casas bahia";
    });
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
