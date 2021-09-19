using System;

namespace Decorator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Decorator");

            Orcamento orcamento = new Orcamento(500);
            var icms = new ICMS();
            Console.WriteLine(string.Format("ICMS: {0}", icms.Calcular(orcamento)));

            var icmsiss = new ICMS(new ISS());
            Console.WriteLine(string.Format("ICMS+ISS: {0}", icmsiss.Calcular(orcamento)));

            var impostoMtoAlto = new ImpostoMuitoAlto(new ICMS(new ISS()));
            Console.WriteLine(string.Format("ImpostoMtoAlto+ICMS+ISS: {0}", impostoMtoAlto.Calcular(orcamento)));

            Console.ReadKey();
        }
    }
}
