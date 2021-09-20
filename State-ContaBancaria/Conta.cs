namespace State_ContaBancaria
{
    public class Conta
    {
        public double Saldo { get; set; }
        public IEstado Estado { get; set; }

        public Conta(double saldo)
        {
            this.Saldo = saldo;
            this.Estado = new Positivo();
        }

        public void Positivar() 
        {
            this.Estado.Positivar(this);
        }

        public void Negativar() 
        {
            this.Estado.Negativar(this);
        }

        public void Depositar(double valor)
        {
            this.Estado.Depositar(this, valor);
        }

        public void Sacar(double valor) 
        {
            this.Estado.Sacar(this, valor);
        }
    }
}
