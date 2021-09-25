using System;

namespace Visitor
{
    public class ImpressoraVisitor : IVisitor
    {
        public void ImprimeSoma(Soma soma)
        {
            Console.Write("(");
            soma.Left.Aceita(this);
            Console.Write(" + ");
            soma.Right.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSoma2(Soma soma)
        {
            Console.Write(" + ");            
            soma.Left.Aceita2(this);
            Console.Write(" ");
            soma.Right.Aceita2(this);            
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            Console.Write("(");
            subtracao.Left.Aceita(this);
            Console.Write(" - ");
            subtracao.Right.Aceita(this);
            Console.Write(")");
        }

        public void ImprimeSubtracao2(Subtracao subtracao)
        {
            Console.Write(" - ");
            subtracao.Left.Aceita2(this);
            Console.Write(" ");
            subtracao.Right.Aceita2(this);
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.Write(numero.Valor);
        }
    }
}
