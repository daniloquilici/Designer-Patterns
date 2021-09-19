namespace DesignPatterns.Imposto
{
    public class ICPP : TemplateImposto
    {
        public override bool ExecutaValorMaximo(Orcamento orcamento)
        {
            if (orcamento.Valor < 500)
                return false;

            return true;
        }

        public override double MaximoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimoValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
