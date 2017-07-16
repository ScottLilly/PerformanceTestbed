namespace Engine.Tests.SwitchVsIfElse
{
    public class PerfTestIfElse : IScenario
    {
        public string Name => "IfElse";

        public void Execute()
        {
            int x = 3;
            int y = 0;

            if (x == 1)
            {
                y = 1;
            }
            else if (x == 2)
            {
                y = 2;
            }
            else if (x == 3)
            {
                y = 3;
            }
            else if (x == 4)
            {
                y = 4;
            }
            else if (x == 5)
            {
                y = 5;
            }
        }
    }
}