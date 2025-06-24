using ImpostoUF.Domain.Entities;

namespace ImpostoUF.Application.Interfaces.Strategy
{
    public interface IRelatorioGenerator
    {
        List<ArrecadacaoIpi> GerarRelatorio();
    }
}
