using ImpostoUF.Application.ConcreteStrategies;

using ImpostoUF.Application.Interfaces.Strategy;
using ImpostoUF.Domain.Enums;

namespace ImpostoUF.Application.Factory
{
    public static class RelatorioFactory
    {
        public static IRelatorioGenerator CriarRelatorio(string relatorio)
        {
            return relatorio switch
            {
                TipoRelatorio.MediaAnual => new MediaArrecadacaoAnualGenerator(),
                TipoRelatorio.EstadosTop => new EstadosMaisArrecadamGenerator(),
                _ => throw new ArgumentException($"Tipo de relatório '{relatorio}' não suportado.", nameof(relatorio))
            };
        }
    }
}
