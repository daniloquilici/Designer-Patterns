using System.Linq;

namespace DesignPatterns.Imposto
{
    public class IHIT : TemplateImposto
    {
        public override bool ExecutaValorMaximo(Orcamento orcamento)
        {
            if (orcamento.Itens.GroupBy(x => x.Nome).Any(y => y.Count() > 1))
                return true;

            return false;
        }

        public override double MaximoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        public override double MinimoValor(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }
    }
}
