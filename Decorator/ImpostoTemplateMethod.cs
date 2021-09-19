namespace Decorator
{
    public abstract class ImpostoTemplateMethod : Imposto
    {
        public ImpostoTemplateMethod() : base()
        {

        }

        public ImpostoTemplateMethod(Imposto outroImposto) : base(outroImposto)
        {

        }

        public abstract bool ExecutarRegraMaiorValor(Orcamento orcamento);

        public abstract double RegraMaiorValor(Orcamento orcamento);

        public abstract double RegraMenorValor(Orcamento orcamento);

        public override double Calcular(Orcamento orcamento)
        {
            if (ExecutarRegraMaiorValor(orcamento))
                return RegraMaiorValor(orcamento) + CalcularOutroImposto(orcamento);

            return RegraMenorValor(orcamento) + CalcularOutroImposto(orcamento);
        }
    }
}
