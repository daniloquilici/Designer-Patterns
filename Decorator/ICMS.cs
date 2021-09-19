namespace Decorator
{
    public class ICMS : Imposto
    {
        public ICMS() : base()
        {

        }

        public ICMS(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.5 + CalcularOutroImposto(orcamento);
        }
    }
}
