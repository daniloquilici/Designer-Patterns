using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Memento");

            HistoricoEstadoContrato historicoEstadoContrato = new HistoricoEstadoContrato();

            Contrato contrato = new Contrato(DateTime.Now, "Danilo", TipoContrato.Novo);
            historicoEstadoContrato.Adicionar(contrato.SalvarEstado());
           
            contrato.AvancarTipo();
            historicoEstadoContrato.Adicionar(contrato.SalvarEstado());

            contrato.AvancarTipo();
            historicoEstadoContrato.Adicionar(contrato.SalvarEstado());

            Console.WriteLine("Tipo Contrato no momento do 2 salvar: {0}", historicoEstadoContrato.GetContrato(2).Contrato.Tipo);

            Console.ReadKey();
        }
    }
}
