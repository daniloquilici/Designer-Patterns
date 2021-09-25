using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bridge");

            IMensagem mensagem = new MensagemAdministrativa("Danilo");
            mensagem.enviador = new EnviarPorEmail();
            mensagem.Envia();

            Console.ReadKey();
        }
    }
}
