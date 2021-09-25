using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Command");

            FilaCommand filaCommand = new FilaCommand();

            var p1 = new Pedido("Danilo", 30);
            var p2 = new Pedido("Japa", 100);

            filaCommand.AddCommand(new PagarPedidoCommand(p1));
            filaCommand.AddCommand(new PagarPedidoCommand(p2));

            filaCommand.AddCommand(new FinalizaPedidoCommand(p1));
            
            filaCommand.ProcessaCommand();

            Console.ReadKey();
        }
    }
}
