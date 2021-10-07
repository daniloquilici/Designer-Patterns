namespace Decorate_StarBuzz
{
    public class Expresso : Beverage
    {
        public Expresso()
        {
            description = "Expresso";
        }

        public override decimal Cost()
        {
            return 1.99M;
        }
    }
}
