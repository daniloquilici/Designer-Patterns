namespace Decorator
{
    public class IKCV : ImpostoTemplateMethod
    {
        public IKCV() : base()
        {

        }

        public IKCV(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override bool ExecutarRegraMaiorValor(Orcamento orcamento)
        {
            //if (orcamento.Valor > 500 && orcamento.Itens.Any(x => x.Valor > 100))
            //    return true;

            if (orcamento.Valor > 500)
                return true;

            return false;
        }

        public override double RegraMaiorValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }

        public override double RegraMenorValor(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}
