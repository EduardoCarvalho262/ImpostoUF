using ImpostoUF.Application.Factory;
using ImpostoUF.Application.Requests;
using ImpostoUF.Domain.Entities;

namespace ImpostoUF.Application.UseCases
{
    public class GerarRelatorioUserCase
    {
        public Task<List<ArrecadacaoIpi>> ExecuteAsync(GerarRelatorioRequest request)
        {
            if(request.Tipo is null)
            {
                return null;
            }

            var estrategia = RelatorioFactory.CriarRelatorio(request.Tipo);

            List<ArrecadacaoIpi> relatorio = estrategia.GerarRelatorio();
            
            return Task.FromResult(relatorio);
        }
    }
}
