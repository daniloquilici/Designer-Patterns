using System;
using System.Collections.Generic;

namespace Flyweight
{
    public class Piano
    {
        public void Tocar(IList<INota> musica)
        {
            foreach (var nota in musica)
            {
                Console.Beep(nota.Frequencia, 300);
            }
        }
    }
}
