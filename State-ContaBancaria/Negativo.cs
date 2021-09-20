using System;

namespace State_ContaBancaria
{
    public class Negativo : IEstado
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
}
