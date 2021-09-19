namespace DesignPatterns.Imposto
{
    public class ICMS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return ((orcamento.Valor * 0.5) + 50);
        }
    }
}
