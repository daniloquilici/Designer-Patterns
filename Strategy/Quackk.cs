using System;

namespace Strategy
{
    public class Quackk : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}
