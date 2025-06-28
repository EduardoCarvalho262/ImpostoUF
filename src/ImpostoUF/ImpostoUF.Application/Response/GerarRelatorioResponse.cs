namespace ImpostoUF.Application.Response
{
    public class GerarRelatorioResponse<TData>
    {
        public bool Sucesso { get; set; }
        public string? MensagemErro { get; set; } 
        public TData? Dados { get; set; } 

        public GerarRelatorioResponse()
        {
            Sucesso = true;
            MensagemErro = null; 
            Dados = default(TData); 
        }

        public GerarRelatorioResponse(TData dados)
        {
            Sucesso = true;
            MensagemErro = null;
            Dados = dados;
        }

        public GerarRelatorioResponse(string mensagemErro)
        {
            Sucesso = false;
            MensagemErro = mensagemErro;
            Dados = default(TData);
        }

        public static GerarRelatorioResponse<TData> Success() => new GerarRelatorioResponse<TData>();

        public static GerarRelatorioResponse<TData> Success(TData dados) => new GerarRelatorioResponse<TData>(dados);

        public static GerarRelatorioResponse<TData> Fail(string mensagemErro) => new GerarRelatorioResponse<TData>(mensagemErro);

    }
}
