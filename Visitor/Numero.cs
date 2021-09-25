namespace Visitor
{
    public class Numero : IExpressao
    {
        public int Valor { get; private set; }

        public Numero(int valor)
        {
            this.Valor = valor;
        }

        public int Avalia()
        {
            return this.Valor;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }

        public void Aceita2(IVisitor visitor)
        {
            visitor.ImprimeNumero(this);
        }
    }
}
