using ImpostoUF.Domain.Entities;
using ImpostoUF.Domain.Interfaces.Strategy;

namespace ImpostoUF.Domain.ConcreteStrategies
{
    public class EstadosMaisArrecadamGenerator : IRelatorioGenerator
    {
        public string TipoRelatorio => "TODO";

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
