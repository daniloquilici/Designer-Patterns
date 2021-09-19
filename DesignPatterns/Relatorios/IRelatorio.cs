using DesignPatterns.Investimento;

namespace DesignPatterns.Relatorios
{
    public interface IRelatorio
    {
        public string Imprimir(TipoExibicao tipoExibicao);
    }
}
