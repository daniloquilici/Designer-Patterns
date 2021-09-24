using System;

namespace Observer
{
    public class EnviarEmail : IAcoesNotafiscal
    {
        public void Executar(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Nota enviada por e-mail com sucesso.");
        }
    }
}
