using ImpostoUF.Domain.Interfaces.Strategy;
using ImpostoUF.Domain.Entities;

namespace ImpostoUF.Domain.ConcreteStrategies
{
    public class MediaArrecadacaoAnualGenerator : IRelatorioGenerator
    {
        public string TipoRelatorio => "media-anual";

        public List<ArrecadacaoIpi> GerarRelatorio()
        {
            ArrecadacaoIpi arrecadacaoIpi = new ArrecadacaoIpi();
            arrecadacaoIpi.Ano = 2012;
            arrecadacaoIpi.Mes = 02;
            arrecadacaoIpi.IpiFumo = 23.09;
            arrecadacaoIpi.IpiImportacoes = 234.45;
            arrecadacaoIpi.IpiAutomoveis = 20.45;

            var lista = new List<ArrecadacaoIpi>();
            lista.Add(arrecadacaoIpi);

            return lista;
        }
    }
}
