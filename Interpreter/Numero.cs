namespace Interpreter
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
    }
}
