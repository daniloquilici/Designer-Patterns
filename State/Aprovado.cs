namespace State
{
    public class Aprovado : IEstado
    {
        private bool descontoAplicado = false;
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                descontoAplicado = true;
            }
            else
                throw new System.Exception("Desconto já aplicado");
        }

        public void Aprovar(Orcamento orcamento)
        {
            throw new System.Exception("Orçamento já está aprovado.");
        }

        public void Finalizar(Orcamento orcamento)
        {
            orcamento.Estado = new Finalizado();
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
