using System;

namespace DesignPatterns.Requisicao
{
    public class ProcessarRequisicao
    {
        public void Processar(Conta conta, Requisicao requisicao)
        {
            var tipo1 = new TipoXML();
            var tipo2 = new TipoCSV();
            var tipo3 = new TipoPorcento();

            tipo1.Proximo = tipo2;
            tipo2.Proximo = tipo3;
            tipo3.Proximo = null;

            Console.WriteLine(tipo1.Processar(conta, requisicao));
        }
    }
}
