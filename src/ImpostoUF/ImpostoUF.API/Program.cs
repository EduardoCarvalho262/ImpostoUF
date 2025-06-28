using ImpostoUF.Application.UseCases;
using ImpostoUF.Application.UseCases.Interfaces;
using ImpostoUF.Domain.ConcreteStrategies;
using ImpostoUF.Domain.Interfaces.Strategy;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRelatorioGenerator, MediaArrecadacaoAnualGenerator>();
builder.Services.AddTransient<IRelatorioGenerator, EstadosMaisArrecadamGenerator>();
builder.Services.AddScoped<IUserCase,GerarRelatorioUserCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/relatorio/{tipo}", (string tipo)  =>
{
    return tipo;
});


app.Run();
