using System.Collections.Generic;

namespace Memento
{
    public class HistoricoContrato
    {
        private IList<Contrato> contratos;

        public HistoricoContrato()
        {
            this.contratos = new List<Contrato>();
        }

        public void AdicionarContrato(Contrato contrato)
        {
            this.contratos.Add(contrato);
        }

        public Contrato GetContrato(int index)
        {
            return this.contratos[index];
        }
    }
}
