using System;
using System.Collections.Generic;

namespace Flyweight
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Flyweinght");

            NotasMusicais notas = new NotasMusicais();

            IList<INota> musica = new List<INota>()
            {
                notas.Get("do"),
                notas.Get("re"),
                notas.Get("mi"),
                notas.Get("fa"),
                notas.Get("fa"),
                notas.Get("fa"),
                
            };

            Piano piano = new Piano();
            piano.Tocar(musica);

            Console.ReadKey();
        }
    }
}
