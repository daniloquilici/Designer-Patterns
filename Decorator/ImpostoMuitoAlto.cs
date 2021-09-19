namespace Decorator
{
    public class ImpostoMuitoAlto : Imposto
    {
        public ImpostoMuitoAlto() : base()
        {

        }

        public ImpostoMuitoAlto(Imposto outroImposto) : base(outroImposto)
        {

        }

        public override double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.2 + CalcularOutroImposto(orcamento);
        }
    }
}
