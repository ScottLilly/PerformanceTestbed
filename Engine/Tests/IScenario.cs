namespace Engine.Tests
{
    public interface IScenario
    {
        string Name { get; }
        void Execute();
    }
}