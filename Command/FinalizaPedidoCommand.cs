using System;

namespace Command
{
    public class FinalizaPedidoCommand : ICommand
    {
        private Pedido pedido;

        public FinalizaPedidoCommand(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine(string.Format("Finaliza pedido do cliente {0}", this.pedido.Cliente));
            this.pedido.FinalizaPedido();
        }
    }
}
