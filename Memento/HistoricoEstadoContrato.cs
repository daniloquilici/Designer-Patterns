using System.Collections.Generic;

namespace Memento
{
    public class HistoricoEstadoContrato
    {
        private IList<Estado> estadosContrato;

        public HistoricoEstadoContrato()
        {
            estadosContrato = new List<Estado>();
        }

        public void Adicionar(Estado estado)
        {
            estadosContrato.Add(estado);
        }

        public Estado GetContrato(int index) 
        {
            return this.estadosContrato[index];
        }
    }
}
