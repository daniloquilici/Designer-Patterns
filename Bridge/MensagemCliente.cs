namespace Bridge
{
    public class MensagemCliente : IMensagem
    {
        private string nome;
        public IEnviador enviador { get; set; }

        public MensagemCliente(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o cliente {0}.", nome);
        }
    }
}
