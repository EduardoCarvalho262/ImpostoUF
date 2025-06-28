using ImpostoUF.Application.Requests;
using ImpostoUF.Application.Response;
using ImpostoUF.Domain.Entities;

namespace ImpostoUF.Application.UseCases.Interfaces
{
    public interface IUserCase
    {
        public Task<GerarRelatorioResponse<List<ArrecadacaoIpi>>> ExecuteAsync(GerarRelatorioRequest request);
    }
}
