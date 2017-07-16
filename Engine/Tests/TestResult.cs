namespace Engine.Tests
{
    public class TestResult
    {
        public int Index { get; set; }
        public long NumberOfTicks { get; set; }

        public TestResult(int index, long numberOfTicks)
        {
            Index = index;
            NumberOfTicks = numberOfTicks;
        }
    }
}