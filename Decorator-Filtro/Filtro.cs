using System.Collections.Generic;

namespace Decorator_Filtro
{
    public abstract class Filtro
    {
        public Filtro ProximoFiltro { get; private set; }

        public Filtro()
        {
            this.ProximoFiltro = null;
        }

        public Filtro(Filtro proximoFiltro)
        {
            this.ProximoFiltro = proximoFiltro;
        }

        public abstract IList<Conta> Filtrar(IList<Conta> contas);

        protected IList<Conta> ExecutarProximoFiltro(IList<Conta> contas)
        {
            if (this.ProximoFiltro != null)
                return this.ProximoFiltro.Filtrar(contas);

            return null;
        }
    }
}
