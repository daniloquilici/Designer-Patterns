using System.Linq;

namespace DesignPatterns.Imposto
{
    public class IKCV : TemplateImposto
    {
        public override bool ExecutaValorMaximo(Orcamento orcamento)
        {
            if (orcamento.Valor > 500 && orcamento.Itens.Any(x => x.Valor > 100))
                return true;

            return false;
        }

        public override double MaximoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double MinimoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
