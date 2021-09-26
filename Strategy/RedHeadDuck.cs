namespace Strategy
{
    public class RedHeadDuck : Duck
    {
        public RedHeadDuck()
        {
            SetFlyBehavior(new FlyNoWay());
            SetQuackBehavior(new MuteQuack());
        }
    }
}
