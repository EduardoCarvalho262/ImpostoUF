using ImpostoUF.Domain.Entities;
using ImpostoUF.Domain.Interfaces.Strategy;

namespace ImpostoUF.Domain.ConcreteStrategies
{
    public class EstadosMaisArrecadamGenerator : IRelatorioGenerator
    {
        public string TipoRelatorio => "estado-arrecadacao";

        public List<ArrecadacaoIpi> GerarRelatorio()
        {
            ArrecadacaoIpi arrecadacaoIpi = new()
            {
                Ano = 2012,
                Mes = 02,
                IpiFumo = 23.09,
                IpiImportacoes = 234.45,
                IpiAutomoveis = 20.45
            };

            var lista = new List<ArrecadacaoIpi> { arrecadacaoIpi };
            return lista;
        }
    }
}
