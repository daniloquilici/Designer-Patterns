using System;

namespace DesignPatterns.Investimento
{
    public class RealizadorDeInvestimentos
    {
        public void Investir(Conta conta, IInvestidor investidor) 
        {
            var valorInvestido = investidor.Investir(conta);
            Console.WriteLine("Saldo: " + conta.Saldo);
            conta.Depositar(valorInvestido * 0.75);
            Console.WriteLine("Novo saldo: " + conta.Saldo);
        }
    }
}
