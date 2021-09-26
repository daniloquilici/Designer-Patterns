using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Strategy");

            var malladDuck = new MallardDuck();
            malladDuck.FlyBehavior.Fly();
            malladDuck.QuackBehavior.Quack();

            Console.WriteLine();

            var redHeadDuck = new RedHeadDuck();
            redHeadDuck.FlyBehavior.Fly();
            redHeadDuck.QuackBehavior.Quack();

            Console.ReadKey();
        }
    }
}
