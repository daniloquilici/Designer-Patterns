using System;

namespace State
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("State");

            var orcamento = new Orcamento(500);
            Console.WriteLine("Valor: " + orcamento.Valor);

            orcamento.AplicarDescontoExtra();
            Console.WriteLine("Valor: " + orcamento.Valor);
            orcamento.AplicarDescontoExtra();
            orcamento.Aprovar();

            orcamento.AplicarDescontoExtra();
            Console.WriteLine("Valor: " + orcamento.Valor);
            orcamento.Finalizar();

            orcamento.AplicarDescontoExtra();

            Console.ReadLine();
        }
    }
}
