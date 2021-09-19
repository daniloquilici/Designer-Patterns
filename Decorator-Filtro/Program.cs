using System;
using System.Collections.Generic;

namespace Decorator_Filtro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorate - Filtro");

            IList<Conta> contas = new List<Conta>();
            contas.Add(new Conta(99.00, DateTime.Now.AddDays(200)));
            contas.Add(new Conta(20.00, DateTime.Now.AddDays(200)));
            contas.Add(new Conta(500000.01, DateTime.Now.AddDays(150)));
            contas.Add(new Conta(200, DateTime.Now));
            contas.Add(new Conta(205, DateTime.Now));
            contas.Add(new Conta(300, DateTime.Now.AddDays(-400)));

            var filtros = new SaldoMaior500Mil(new SaldoMenor100(new DataAberturaMesCorrente()));
            var contasFiltradas = filtros.Filtrar(contas);

            Console.WriteLine("Qtd: " + contasFiltradas.Count);

            Console.ReadKey();
        }
    }
}
