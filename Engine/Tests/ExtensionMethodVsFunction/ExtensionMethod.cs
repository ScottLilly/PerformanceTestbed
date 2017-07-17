namespace Engine.Tests.ExtensionMethodVsFunction
{
    public class ExtensionMethod : IScenario
    {
        public string Name => "Extension Method";

        public void Execute()
        {
            int spaces = "asd fgh jkl ".NumberOfSpacesIn();
        }
    }
}