namespace Decorate_StarBuzz
{
    public abstract class Beverage
    {
        protected string description;

        public string GetDescription() 
        {
            return description;
        }

        public abstract decimal Cost();
    }
}
