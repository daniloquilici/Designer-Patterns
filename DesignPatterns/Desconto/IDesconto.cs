namespace DesignPatterns.Desconto
{
    public interface IDesconto
    {
        public IDesconto Proximo { get; set; }
        double Calcular(Orcamento orcamento);
    }
}
