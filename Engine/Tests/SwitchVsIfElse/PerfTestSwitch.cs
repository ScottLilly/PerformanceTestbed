namespace Engine.Tests.SwitchVsIfElse
{
    public class PerfTestSwitch : IScenario
    {
        public string Name => "Switch";

        public void Execute()
        {
            int x = 3;
            int y = 0;

            switch(x)
            {
                case 1:
                    y = 1;
                    break;
                case 2:
                    y = 2;
                    break;
                case 3:
                    y = 3;
                    break;
                case 4:
                    y = 4;
                    break;
                case 5:
                    y = 5;
                    break;
            }
        }
    }
}