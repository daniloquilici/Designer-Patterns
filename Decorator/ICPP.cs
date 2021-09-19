namespace Decorator
{
    public class ICPP : ImpostoTemplateMethod
    {
        public ICPP() : base()
        {

        }

        public ICPP(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override bool ExecutarRegraMaiorValor(Orcamento orcamento)
        {
            if (orcamento.Valor < 500)
                return false;

            return true;
        }

        public override double RegraMaiorValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double RegraMenorValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.05;
        }
    }
}
