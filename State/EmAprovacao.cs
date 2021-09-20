namespace State
{
    public class EmAprovacao : IEstado
    {
        private bool descontoAplicado = false;
        public void AplicarDescontoExtra(Orcamento orcamento)
        {
            if (!descontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.05;
                descontoAplicado = true;
            }
            else
                throw new System.Exception("Desconto já aplicado");
        }

        public void Aprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Aprovado();
        }

        public void Finalizar(Orcamento orcamento)
        {
            throw new System.Exception("Não é possivel finalizer um orçamento em Aprovação;");
        }

        public void Reprovar(Orcamento orcamento)
        {
            orcamento.Estado = new Reprovado();
        }
    }
}
