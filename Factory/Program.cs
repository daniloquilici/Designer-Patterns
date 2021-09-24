using System;
using System.Data;

namespace Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Factory");

            IDbConnection connection = new ConnectionFactory().GetConnection();

            IDbCommand comando = connection.CreateCommand();
            comando.CommandText = "Select * from usuario;";
            var usuarios = comando.ExecuteReader();
        }
    }
}
