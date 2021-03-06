using System;

namespace Observer2
{
    public class StatisticDisplayObserver : IObserver
    {
        public WaetherData WaetherData { get; private set; }

        public StatisticDisplayObserver(WaetherData waetherData)
        {
            this.WaetherData = waetherData;
            waetherData.RegisterObserver(this);
        }

        public void Update()
        {
            Console.WriteLine(string.Format("Notificando o observardor {0}.", this.GetType().Name));
        }
    }
}
