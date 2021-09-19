namespace Decorator
{
    public abstract class Imposto
    {
        public Imposto OutroImposto { get; set; }
        public abstract double Calcular(Orcamento orcamento);

        public Imposto()
        {
            this.OutroImposto = null;
        }

        public Imposto(Imposto outroImposto)
        {
            this.OutroImposto = outroImposto;
        }

        protected double CalcularOutroImposto(Orcamento orcamento)
        {
            if (this.OutroImposto == null)
                return 0;
            
            return this.OutroImposto.Calcular(orcamento);
        }
    }
}
