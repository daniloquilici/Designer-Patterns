using System;

namespace Decorate_StarBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("StarBuzz Coffee");

            Beverage beverage = new Expresso();
            Console.WriteLine($"{beverage.GetDescription()} - Valor: {beverage.Cost()}");
            beverage = new Milk(beverage);
            Console.WriteLine($"{beverage.GetDescription()} - Valor: {beverage.Cost()}");
            beverage = new Mocha(beverage);
            Console.WriteLine($"{beverage.GetDescription()} - Valor: {beverage.Cost()}");
            
            Console.ReadKey();
        }
    }
}
