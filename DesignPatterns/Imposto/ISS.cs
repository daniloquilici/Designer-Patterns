namespace DesignPatterns.Imposto
{
    public class ISS : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            return orcamento.Valor * 0.6;
        }
    }
}
