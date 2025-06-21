using ImpostoUF.Application.Requests;
using ImpostoUF.Domain.Entities;

namespace ImpostoUF.Application.UseCases
{
    public class GerarRelatorioUserCase
    {
        public Task<List<ArrecadacaoIpi>> ExecuteAsync(GerarRelatorioRequest request)
        {

            //Verificar se a request está nula

            //Pegar a estrategia correta

            //Executar a estratégia

            //Retornar o objeto em Json para Frontend Consumir


            ArrecadacaoIpi arrecadacaoIpi = new ArrecadacaoIpi();
            arrecadacaoIpi.Ano = 2012;
            arrecadacaoIpi.Mes = 02;
            arrecadacaoIpi.IpiFumo = 23.09;
            arrecadacaoIpi.IpiImportacoes = 234.45;
            arrecadacaoIpi.IpiAutomoveis = 20.45;

            var lista = new List<ArrecadacaoIpi>();
            lista.Add(arrecadacaoIpi);
            return Task.FromResult(lista);
        }
    }
}
