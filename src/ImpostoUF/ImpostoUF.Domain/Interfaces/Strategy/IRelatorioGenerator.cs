using ImpostoUF.Domain.Entities;

namespace ImpostoUF.Domain.Interfaces.Strategy
{
    public interface IRelatorioGenerator
    {
        string TipoRelatorio { get; }
        List<ArrecadacaoIpi> GerarRelatorio();
    }
}
