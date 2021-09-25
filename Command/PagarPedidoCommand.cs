using System;

namespace Command
{
    public class PagarPedidoCommand : ICommand
    {
        private Pedido pedido;

        public PagarPedidoCommand(Pedido pedido)
        {
            this.pedido = pedido;
        }

        public void Executa()
        {
            Console.WriteLine(string.Format("Paga pedido do cliente {0}", this.pedido.Cliente));
            this.pedido.PagaPedido();
        }
    }
}
