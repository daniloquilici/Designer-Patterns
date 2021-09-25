namespace Bridge
{
    public class MensagemAdministrativa : IMensagem
    {
        private string nome;
        public IEnviador enviador { get; set; }

        public MensagemAdministrativa(string nome)
        {
            this.nome = nome;
        }

        public void Envia()
        {
            this.enviador.Envia(this);
        }

        public string Formata()
        {
            return string.Format("Enviando mensagem para o administrador {0}.", nome);
        }
    }
}
