using System;

namespace CarFactory
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var audiFac = new AUDICarFactory();
            var audiBody = audiFac.CreateBody();
            var audiEngine = audiFac.CreateEngine();
            var audiInterior = audiFac.CreateInterior();
            var bmwFac = new BMWCarFactory();
            var bmwBody = bmwFac.CreateBody();
            var bmwEngine = bmwFac.CreateEngine();
            var bmwInterior = bmwFac.CreateInterior();
        }
    }
}