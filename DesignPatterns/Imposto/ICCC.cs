namespace DesignPatterns.Imposto
{
    public class ICCC : IImposto
    {
        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor < 1000)
                return orcamento.Valor * 0.5;
            else if (orcamento.Valor >= 1000 && orcamento.Valor <= 3000)
                return orcamento.Valor * 0.7;
            else
                return orcamento.Valor * 0.8 + 30;
        }
    }
}
