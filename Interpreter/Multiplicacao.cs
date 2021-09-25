namespace Interpreter
{
    public class Multiplicacao : IExpressao
    {
        public IExpressao Left { get; private set; }
        public IExpressao Right { get; private set; }

        public Multiplicacao(IExpressao left, IExpressao right)
        {
            this.Left = left;
            this.Right = right;
        }

        public int Avalia()
        {
            var left = this.Left.Avalia();
            var right = this.Right.Avalia();

            return left * right;
        }
    }
}
