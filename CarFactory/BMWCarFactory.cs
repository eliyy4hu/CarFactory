namespace CarFactory
{
    public class BMWCarFactory : IСarFactory
    {
        public IBody CreateBody()
        {
            return new BMWBody();
        }

        public IEngine CreateEngine()
        {
            return new BMWEngine();
        }

        public IInterior CreateInterior()
        {
            return new BMWInterior();
        }
    }
    public class BMWInterior : IInterior
    {
        public int Capacity => 4;
    }

    public class BMWEngine : IEngine
    {
        public string MotorPowerType => "V";
        public int CylindersCount => 4;
        public double EngineVolume => 300;
    }

    public class BMWBody : IBody
    {
        public int Length => 5;
        public int Width => 3;
        public int Height => 1;
    }
}