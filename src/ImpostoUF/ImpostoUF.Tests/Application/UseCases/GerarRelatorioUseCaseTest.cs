using ImpostoUF.Application.Requests;
using ImpostoUF.Application.Response;
using ImpostoUF.Application.UseCases;
using ImpostoUF.Domain.ConcreteStrategies;
using ImpostoUF.Domain.Entities;
using ImpostoUF.Domain.Interfaces.Strategy;
using Moq;
using Shouldly;

namespace ImpostoUF.Tests.Application.UseCases
{
    public class GerarRelatorioUseCaseTest
    {
        private readonly GerarRelatorioUserCase _gerarRelatorioUseCase;
        public GerarRelatorioUseCaseTest() 
        {
            var lista = new List<IRelatorioGenerator>();
            lista.Add(new MediaArrecadacaoAnualGenerator());
            _gerarRelatorioUseCase = new GerarRelatorioUserCase(lista.AsEnumerable());
        }

        [Fact]
        public void DadoRequestTipoMediaAnualIpiEstados_QuandoChamarOUseCase_RetornarUmaListaDeArrecadacao()
        {
            //Arrange
            var request = new GerarRelatorioRequest { Tipo = "media-anual" };
            ArrecadacaoIpi arrecadacaoIpi = new ArrecadacaoIpi();
            arrecadacaoIpi.Ano = 2012;
            arrecadacaoIpi.Mes = 02;
            arrecadacaoIpi.IpiFumo = 23.09;
            arrecadacaoIpi.IpiImportacoes = 234.45;
            arrecadacaoIpi.IpiAutomoveis = 20.45;

            //Act
            Task<GerarRelatorioResponse<List<ArrecadacaoIpi>>> response = _gerarRelatorioUseCase.ExecuteAsync(request);

            //Assert
            response.Result.Dados.ShouldHaveSingleItem();
        }
    }
}
