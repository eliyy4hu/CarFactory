namespace CarFactory
{
    public interface IСarFactory
    {
        IBody CreateBody();
        IEngine CreateEngine();
        IInterior CreateInterior();
    }
    
    public interface IInterior
    {
        int Capacity { get; }
    }

    public interface IEngine
    {
        string MotorPowerType { get; }
        int CylindersCount { get; }
        double EngineVolume { get; }
    }

    public interface IBody
    {
        int Length { get; }
        int Width { get; }
        int Height { get; }
    }
}