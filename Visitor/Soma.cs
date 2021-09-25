namespace Visitor
{
    public class Soma : IExpressao
    {
        public IExpressao Left { get; private set; }
        public IExpressao Right { get; private set; }

        public Soma(IExpressao left, IExpressao right)
        {
            this.Left = left;
            this.Right = right;
        }

        public int Avalia()
        {
            var left = this.Left.Avalia();
            var right = this.Right.Avalia();

            return left + right;
        }

        public void Aceita(IVisitor visitor)
        {
            visitor.ImprimeSoma(this);
        }

        public void Aceita2(IVisitor visitor)
        {
            visitor.ImprimeSoma2(this);
        }
    }
}
