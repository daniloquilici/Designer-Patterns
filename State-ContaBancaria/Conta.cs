using System;

namespace State_ContaBancaria
{
    public class Conta
    {
        public double Saldo { get; private set; }
        public IEstado Estado { get; private set; }

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

        #region Posistivo

        class Positivo : IEstado
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.98;
            }

            public void Negativar(Conta conta)
            {
                conta.Estado = new Negativo();
            }

            public void Positivar(Conta conta)
            {
                throw new Exception("Conta já positivada.");

            }

            public void Sacar(Conta conta, double valor)
            {
                conta.Saldo -= valor;
                if (conta.Saldo < 0)
                    this.Negativar(conta);
            }
        }

        #endregion

        #region Negativo

        class Negativo : IEstado
        {
            public void Depositar(Conta conta, double valor)
            {
                conta.Saldo += valor * 0.95;
                if (conta.Saldo > 0)
                    this.Positivar(conta);
            }

            public void Negativar(Conta conta)
            {
                throw new Exception("Conta já negativada.");
            }

            public void Positivar(Conta conta)
            {
                conta.Estado = new Positivo();
            }


            public void Sacar(Conta conta, double valor)
            {
                throw new Exception("Contas com saldo negativo não podem efetuar saques.");
            }
        }

        #endregion
    }
}
