using System.Collections.Generic;
using System.Linq;

namespace Decorator_Filtro
{
    public class SaldoMenor100 : Filtro
    {
        public SaldoMenor100() : base()
        {

        }

        public SaldoMenor100(Filtro proximoFiltro) : base(proximoFiltro)
        {

        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var listaContas = new List<Conta>();
            listaContas.AddRange(contas.Where(x => x.Saldo < 100));

            var listaContasProximoFiltro = ExecutarProximoFiltro(contas);
            if (listaContasProximoFiltro != null)
                listaContas.AddRange(listaContasProximoFiltro);

            return listaContas;
        }
    }
}
