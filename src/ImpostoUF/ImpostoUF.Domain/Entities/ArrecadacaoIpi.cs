namespace ImpostoUF.Domain.Entities
{
    public class ArrecadacaoIpi
    {
        public int Ano { get; set; }
        public int Mes {  get; set; }
        public string? SiglaUF { get; set; }
        public double IpiFumo { get; set; }
        public double IpiBebidas { get; set; }
        public double IpiAutomoveis { get; set; }
        public double IpiImportacoes { get; set; }
        public double IpiOutros { get; set; }
    }
}
