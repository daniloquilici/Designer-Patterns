using System;

namespace Bridge
{
    public class EnviarPorSMS : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviado mensagem por SMS.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
