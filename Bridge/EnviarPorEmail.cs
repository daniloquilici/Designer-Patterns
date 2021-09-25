using System;

namespace Bridge
{
    public class EnviarPorEmail : IEnviador
    {
        public void Envia(IMensagem mensagem)
        {
            Console.WriteLine("Enviado mensagem por e-mail.");
            Console.WriteLine(mensagem.Formata());
        }
    }
}
