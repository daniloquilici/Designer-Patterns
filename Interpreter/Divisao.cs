namespace Interpreter
{
    public class Divisao : IExpressao
    {
        public IExpressao Left { get; private set; }
        public IExpressao Right { get; private set; }

        public Divisao(IExpressao left, IExpressao right)
        {
            this.Left = left;
            this.Right = right;
        }

        public int Avalia()
        {
            var left = this.Left.Avalia();
            var right = this.Right.Avalia();

            if (right == 0)
                return 0;

            return left / right;
        }
    }
}
