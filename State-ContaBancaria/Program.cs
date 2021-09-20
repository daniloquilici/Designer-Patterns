using System;

namespace State_ContaBancaria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State - Conta Bancaria");

            var conta = new Conta(500);
            Console.WriteLine("Saldo: " + conta.Saldo);
            conta.Depositar(100);
            Console.WriteLine("Saldo: " + conta.Saldo);
            conta.Sacar(800);
            Console.WriteLine("Saldo: " + conta.Saldo);
            conta.Sacar(100);

            Console.ReadKey();
        }
    }
}
