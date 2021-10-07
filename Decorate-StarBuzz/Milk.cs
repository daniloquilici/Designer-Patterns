namespace Decorate_StarBuzz
{
    public class Milk : CondimentDecorator
    {
        Beverage beverage;
        public Milk(Beverage beverage)
        {
            this.beverage = beverage;
            description = $"{this.beverage.GetDescription()}, Milk";
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()}, Milk";
        }

        public override decimal Cost()
        {
            return .35M + this.beverage.Cost();
        }
    }
}
