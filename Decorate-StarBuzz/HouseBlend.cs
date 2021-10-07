namespace Decorate_StarBuzz
{
    public class HouseBlend : Beverage
    {
        public HouseBlend()
        {
            description = "House Blend Coffe";
        }

        public override decimal Cost()
        {
            return .89M;
        }

    }
}
