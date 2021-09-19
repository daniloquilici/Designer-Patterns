namespace DesignPatterns.Requisicao
{
    public interface ITipoProcessamento
    {
        public ITipoProcessamento Proximo { get; set; }

        public string Processar(Conta conta, Requisicao requisicao);
    }
}
