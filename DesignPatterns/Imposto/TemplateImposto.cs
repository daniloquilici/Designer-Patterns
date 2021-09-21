namespace DesignPatterns.Imposto
{
    public abstract class TemplateImposto : IImposto
    {
        public abstract bool ExecutaValorMaximo(Orcamento orcamento);
        public abstract double MaximoValor(Orcamento orcamento);
        public abstract double MinimoValor(Orcamento orcamento);

        public double Calcular(Orcamento orcamento)
        {
            if (ExecutaValorMaximo(orcamento))
                return MaximoValor(orcamento);

            return MinimoValor(orcamento);
        }
    }
}
