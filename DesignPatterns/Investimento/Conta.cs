namespace DesignPatterns.Investimento
{
    public class Conta
    {
        public string Nome { get; private set; }
        public double Saldo { get; private set; }
        public string Agencia { get; private set; }
        public string NumeroConta { get; private set; }

        public Conta(string nome, double saldo, string agencia, string numeroConta)
        {
            this.Nome = nome;
            this.Saldo = saldo;
            this.Agencia = agencia;
            this.NumeroConta = numeroConta;
        }

        public Conta(double saldo)
        {
            this.Saldo = saldo;
        }

        public void Depositar(double valor) 
        {
            this.Saldo += valor;
        }
    }
}
