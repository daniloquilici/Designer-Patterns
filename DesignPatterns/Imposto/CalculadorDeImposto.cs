using System;

namespace DesignPatterns.Imposto
{
    public class CalculadorDeImposto
    {
        public void CalcularImposto(Orcamento orcamento, IImposto imposto)
        {
            Console.WriteLine(imposto.Calcular(orcamento));
        }
    }
}
