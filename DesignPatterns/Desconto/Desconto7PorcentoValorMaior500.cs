namespace DesignPatterns.Desconto
{
    public class Desconto7PorcentoValorMaior500 : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Calcular(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
                return orcamento.Valor * 0.07;

            return Proximo.Calcular(orcamento);
        }
    }
}
