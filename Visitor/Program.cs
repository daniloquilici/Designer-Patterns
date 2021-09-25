using System;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Visitor");

            IExpressao esquerda = new Subtracao(new Numero(10), new Numero(5));
            IExpressao direita = new Soma(new Numero(2), new Numero(10));
            IExpressao soma = new Soma(esquerda, direita);

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressoraVisitor = new ImpressoraVisitor();
            soma.Aceita(impressoraVisitor);

            Console.WriteLine("");

            Console.WriteLine(soma.Avalia());
            ImpressoraVisitor impressoraVisitor2 = new ImpressoraVisitor();
            soma.Aceita2(impressoraVisitor2);

            Console.ReadKey();
        }
    }
}
