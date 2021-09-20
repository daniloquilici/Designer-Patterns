namespace State
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public IEstado Estado { get; set; }

        public Orcamento(double valor)
        {
            this.Valor = valor;
            this.Estado = new EmAprovacao();
        }

        public void AplicarDescontoExtra() 
        {
            this.Estado.AplicarDescontoExtra(this);
        }

        public void Aprovar() 
        {
            this.Estado.Aprovar(this);
        }

        public void Reprovar()
        {
            this.Estado.Reprovar(this);
        }

        public void Finalizar()
        {
            this.Estado.Finalizar(this);
        }
    }
}
