using System;

namespace Observer
{
    public class NotaFiscalDAO : IAcoesNotafiscal
    {
        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota fiscal salva com sucesso.");
        }
    }
}
