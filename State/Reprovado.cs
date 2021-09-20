namespace State
{
    public class Reprovado : IEstado
    {
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel dar desconto em um orçamento já reprovado.");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel aprovar um orçamento reprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel aprovar um orçamento já reprovado.");
        }
    }
}
