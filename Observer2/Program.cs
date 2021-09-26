using System;

namespace Observer2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Observer 2");

            WaetherData waetherData = new WaetherData();

            CurrentConditionsObserver currentConditionsObserver = new CurrentConditionsObserver(waetherData);
            StatisticDisplayObserver statisticDisplayObserver = new StatisticDisplayObserver(waetherData);
            waetherData.SetMeasurements();

            Console.WriteLine();
            waetherData.RemoveObserver(statisticDisplayObserver);
            waetherData.SetMeasurements();

            Console.ReadKey();
        }
    }
}
