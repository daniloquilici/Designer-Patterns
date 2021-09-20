using System;

namespace State_ContaBancaria
{
    public class Positivo : IEstado
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
}
