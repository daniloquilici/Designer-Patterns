namespace Adapter
{
    public class ServicoSingleton
    {
        private static Servico instancia = new Servico();

        public Servico GetInstancia { get { return instancia; } }
    }
}
