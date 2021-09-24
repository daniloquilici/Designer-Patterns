using System;

namespace Observer
{
    public class Multiplicador : IAcoesNotafiscal
    {
        public int Fator { get; private set; }

        public Multiplicador(int fator)
        {
            this.Fator = fator;
        }

        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Valor da nota * {0} = {1}", Fator, notaFiscal.ValorBruto * this.Fator);
        }
    }
}
