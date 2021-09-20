namespace State
{
    public interface IEstado
    {
        void AplicarDescontoExtra(Orcamento orcamento);

        void Aprovar(Orcamento orcamento);

        void Reprovar(Orcamento orcamento);

        void Finalizar(Orcamento orcamento);
    }
}
