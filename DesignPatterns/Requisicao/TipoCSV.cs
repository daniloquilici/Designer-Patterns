namespace DesignPatterns.Requisicao
{
    public class TipoCSV : ITipoProcessamento
    {
        public ITipoProcessamento Proximo { get; set; }

        public string Processar(Conta conta, Requisicao requisicao)
        {
            if (requisicao.Formato == Formato.CSV)
                return string.Format("{0};{1}", conta.Nome, conta.Saldo);

            return Proximo != null ? Proximo.Processar(conta, requisicao) : "Nenhum tipo encontrado.";
        }
    }
}
