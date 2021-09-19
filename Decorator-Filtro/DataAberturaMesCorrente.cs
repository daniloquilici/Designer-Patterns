using System;
using System.Collections.Generic;
using System.Linq;

namespace Decorator_Filtro
{
    public class DataAberturaMesCorrente : Filtro
    {
        public DataAberturaMesCorrente() : base()
        {

        }

        public DataAberturaMesCorrente(Filtro proximoFiltro) : base(proximoFiltro)
        {

        }

        public override IList<Conta> Filtrar(IList<Conta> contas)
        {
            var listaContas = new List<Conta>();
            listaContas.AddRange(contas.Where(x => x.DataAbertura.Month == DateTime.Now.Month && x.DataAbertura.Year == DateTime.Now.Year));

            var listaContasProximoFiltro = ExecutarProximoFiltro(contas);
            if (listaContasProximoFiltro != null)
                listaContas.AddRange(listaContasProximoFiltro);

            return listaContas;
        }
    }
}
