using System;

namespace Interpreter
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao Numero { get; private set; }

        public RaizQuadrada(IExpressao numero)
        {
            this.Numero = numero;
        }

        public int Avalia()
        {
            var numero = this.Numero.Avalia();
            var rq = Math.Sqrt(numero);

            return (int)rq;
        }
    }
}
