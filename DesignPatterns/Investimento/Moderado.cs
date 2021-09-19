using System;

namespace DesignPatterns.Investimento
{
    public class Moderado : IInvestidor
    {
        private Random random;
        public Moderado()
        {
            this.random = new Random();
        }

        public double Investir(Conta conta)
        {
            if (random.Next(2) == 0)
                return conta.Saldo * 0.025;
            else
                return conta.Saldo * 0.007;
        }
    }
}
