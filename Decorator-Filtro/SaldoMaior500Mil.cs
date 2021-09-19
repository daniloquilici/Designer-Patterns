using System.Collections.Generic;
using System.Linq;

namespace Decorator_Filtro
{
    public class SaldoMaior500Mil : Filtro
    {
        public SaldoMaior500Mil() : base()
        {

        }

        public SaldoMaior500Mil(Filtro proximoFiltro) : base(proximoFiltro)
        {

        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var listaContas = new List<Conta>();
            listaContas.AddRange(contas.Where(x => x.Saldo > 500000.00));

            var listaContasProximoFiltro = ExecutarProximoFiltro(contas);
            if (listaContasProximoFiltro != null)
                listaContas.AddRange(listaContasProximoFiltro);

            return listaContas;
        }
    }
}
