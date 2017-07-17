using System.Linq;

namespace Engine.Tests.ExtensionMethodVsFunction
{
    public class Function : IScenario
    {
        public string Name => "Function";

        public void Execute()
        {
            int spaces = NumberOfSpacesIn("asd fgh jkl ");
        }

        private int NumberOfSpacesIn(string text)
        {
            return text.Where((t, i) => text.Substring(i, 1) == " ").Count();
        }
    }
}