using System;

namespace Strategy
{
    public abstract class Duck
    {
        public IFlyBehavior FlyBehavior { get; private set; }

        public IQuackBehavior QuackBehavior { get; private set; }

        protected void SetFlyBehavior(IFlyBehavior newFlyBehavior) 
        {
            Console.WriteLine("Change fly");
            this.FlyBehavior = newFlyBehavior;        
        }

        protected void SetQuackBehavior(IQuackBehavior newQuackBehavior) 
        {
            Console.WriteLine("Change quack");
            this.QuackBehavior = newQuackBehavior;
        }

        public void Swim() 
        {
            Console.WriteLine("Swimming");
        }
    }
}
