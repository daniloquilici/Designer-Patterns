namespace State
{
    public class Finalizado : IEstado
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel dar desconto em um orçamentro já finalizado.");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel aprovar uma orçamento já finalizado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já finalizado.");
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel reprovar uma orçamento já finalizado.");
        }
    }
}
