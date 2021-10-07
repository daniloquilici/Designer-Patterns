namespace Decorate_StarBuzz
{
    public class Mocha : CondimentDecorator
    {
        Beverage beverage;
        public Mocha(Beverage beverage)
        {
            this.beverage = beverage;
            description = $"{this.beverage.GetDescription()}, Mocha";
        }

        public override string GetDescription()
        {
            return $"{this.beverage.GetDescription()}, Mocha";
        }

        public override decimal Cost()
        {
            return .20M + this.beverage.Cost();
        }

    }
}
