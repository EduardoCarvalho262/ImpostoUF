using ImpostoUF.Application.Requests;
using ImpostoUF.Application.UseCases;
using ImpostoUF.Application.UseCases.Interfaces;
using ImpostoUF.Domain.ConcreteStrategies;
using ImpostoUF.Domain.Interfaces.Strategy;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IRelatorioGenerator, MediaArrecadacaoAnualGenerator>();
builder.Services.AddTransient<IRelatorioGenerator, EstadosMaisArrecadamGenerator>();
builder.Services.AddScoped<IUserCase, GerarRelatorioUserCase>();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();


app.MapGet("/relatorio/{tipo}", async (string tipo, HttpContext httpContext) =>
{
   
    var userCase = httpContext.RequestServices.GetRequiredService<IUserCase>();

    var request = new GerarRelatorioRequest { Tipo = tipo };
    var response = await userCase.ExecuteAsync(request);

    if (response.MensagemErro is not null)
    {
   
        return Results.BadRequest(response.MensagemErro);
    }

    return Results.Ok(response.Dados);
});

app.Run();
