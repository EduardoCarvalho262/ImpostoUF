using ImpostoUF.Application.Requests;
using ImpostoUF.Application.UseCases;
using ImpostoUF.Domain.Entities;
using Shouldly;

namespace ImpostoUF.Tests.Application.UseCases
{
    public class GerarRelatorioUseCaseTest
    {

        private readonly GerarRelatorioUserCase _gerarRelatorioUseCase;

        public GerarRelatorioUseCaseTest() 
        {
            _gerarRelatorioUseCase = new GerarRelatorioUserCase();
        }


        [Fact]
        public void DadoRequestTipoMediaAnualIpiEstados_QuandoChamarOUseCase_RetornarUmaListaDeArrecadacao()
        {
            //Arrange
            var request = new GerarRelatorioRequest { tipo = "MediaAnualIPIEstados" };
            ArrecadacaoIpi arrecadacaoIpi = new ArrecadacaoIpi();
            arrecadacaoIpi.Ano = 2012;
            arrecadacaoIpi.Mes = 02;
            arrecadacaoIpi.IpiFumo = 23.09;
            arrecadacaoIpi.IpiImportacoes = 234.45;
            arrecadacaoIpi.IpiAutomoveis = 20.45;

            //Act
            Task <List<ArrecadacaoIpi>> response = _gerarRelatorioUseCase.ExecuteAsync(request);

            //Assert
            response.Result.ShouldHaveSingleItem();
        }
    }
}
