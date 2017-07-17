using System.Linq;

namespace Engine.Tests.ExtensionMethodVsFunction
{
    public static class ExtensionFunctions
    {
        public static int NumberOfSpacesIn(this string text)
        {
            return text.Where((t, i) => text.Substring(i, 1) == " ").Count();
        }
    }
}