using ImpostoUF.Application.Requests;
using ImpostoUF.Application.Response;
using ImpostoUF.Application.UseCases.Interfaces;
using ImpostoUF.Domain.Entities;
using ImpostoUF.Domain.Interfaces.Strategy;

namespace ImpostoUF.Application.UseCases
{
    public class GerarRelatorioUserCase : IUserCase
    {
        private readonly IEnumerable<IRelatorioGenerator> _relatorioGenerators;

        public GerarRelatorioUserCase(IEnumerable<IRelatorioGenerator> relatorioGenerators)
        {
            _relatorioGenerators = relatorioGenerators;
        }

        public Task<GerarRelatorioResponse<List<ArrecadacaoIpi>>> ExecuteAsync(GerarRelatorioRequest request)
        {
            if(request.Tipo is null)
            {
                return Task.FromResult(new GerarRelatorioResponse<List<ArrecadacaoIpi>>("Tipo está vazio.")); 
            }

            //TODO buscar os dados do Lambda passando os parâmetros

            var estrategia = _relatorioGenerators.FirstOrDefault(g => g.TipoRelatorio.Equals(request.Tipo, StringComparison.OrdinalIgnoreCase));

            if (estrategia == null) 
            {
                return Task.FromResult(new GerarRelatorioResponse<List<ArrecadacaoIpi>>("Estratégia está vazia.")); 
            }

            List<ArrecadacaoIpi> relatorio = estrategia.GerarRelatorio();
            
            return Task.FromResult(new GerarRelatorioResponse<List<ArrecadacaoIpi>>(relatorio));
        }
    }
}
