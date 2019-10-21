namespace CarFactory
{
    public class AUDICarFactory : IСarFactory
    {
        public IBody CreateBody()
        {
            return new AUDIBody();
        }

        public IEngine CreateEngine()
        {
            return new AUDIEngine();
        }

        public IInterior CreateInterior()
        {
            return new AUDIInterior();
        }
    }
    public class AUDIInterior : IInterior
    {
        public int Capacity => 4;
    }

    public class AUDIEngine : IEngine
    {
        public string MotorPowerType => "VV";
        public int CylindersCount => 5;
        public double EngineVolume => 1337;
    }

    public class AUDIBody : IBody
    {
        public int Length => 5;
        public int Width => 3;
        public int Height => 1;
    }
}