namespace Visitor
{
    public class Subtracao : IExpressao
    {
        public IExpressao Left { get; private set; }
        public IExpressao Right { get; private set; }

        public Subtracao(IExpressao left, IExpressao right)
        {
            this.Left = left;
            this.Right = right;
        }

        public int Avalia()
        {
            var left = this.Left.Avalia();
            var right = this.Right.Avalia();

            return left - right;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSubtracao(this);
        }

        public void Aceita2(IVisitor visitor)
        {
            visitor.ImprimeSubtracao2(this);
        }
    }
}
