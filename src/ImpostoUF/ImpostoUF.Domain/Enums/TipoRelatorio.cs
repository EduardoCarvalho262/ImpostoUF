namespace ImpostoUF.Domain.Enums
{
    public static class TipoRelatorio
    {
        public const string MediaAnual = "media-anual";
        public const string EstadosTop = "estados-top";

        public static bool IsValid(string tipo)
        {
            return tipo == MediaAnual ||
                   tipo == EstadosTop;
        }
    }
}
