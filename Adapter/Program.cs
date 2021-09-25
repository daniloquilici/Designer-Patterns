using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adapter");

            var geradorXML = new GerarXML();
            
            var cliente = new Cliente();
            cliente.Nome = "Danilo";
            cliente.Endereco = "Rua Nelson Gama de Oliveira, 905 Vila Andrade";
            cliente.DataNascimento = DateTime.Now;

            Console.WriteLine(geradorXML.Gerar(cliente));
            Console.ReadKey();
        }
    }
}
