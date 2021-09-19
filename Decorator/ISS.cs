namespace Decorator
{
    public class ISS : Imposto
    {
        public ISS() : base()
        {

        }

        public ISS(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6 + CalcularOutroImposto(orcamento);
        }
    }
}
