using DesignPatterns.Investimento;

namespace DesignPatterns.Relatorios
{
    public abstract class TemplateRelatorio : IRelatorio
    {
        public abstract string ExibicaoSimples();
        public abstract string ExibicaoComplexa();

        public string Imprimir(TipoExibicao tipoExibicao)
        {
            if (tipoExibicao == TipoExibicao.Simples)
                return ExibicaoSimples();

            return ExibicaoComplexa();
        }
    }
}
