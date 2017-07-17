using Engine.Tests;
using Engine.Tests.ExtensionMethodVsFunction;
using Engine.Tests.SwitchVsIfElse;

namespace Engine.ViewModels
{
    public class PerformanceTest : BaseNotificationClass
    {
        private int _iterationsPerRun = 100000;
        private int _numberOfRuns = 10;
        private TestRunner _test1;
        private TestRunner _test2;

        public int NumberOfRuns
        {
            get => _numberOfRuns;
            set
            {
                _numberOfRuns = value;

                OnPropertyChanged(nameof(NumberOfRuns));
            }
        }

        public int IterationsPerRun
        {
            get => _iterationsPerRun;
            set
            {
                _iterationsPerRun = value;

                OnPropertyChanged(nameof(IterationsPerRun));
            }
        }

        public TestRunner Test1
        {
            get => _test1;
            set
            {
                _test1 = value; 
                OnPropertyChanged(nameof(Test1));
            }
        }

        public TestRunner Test2
        {
            get => _test2;
            set
            {
                _test2 = value; 
                OnPropertyChanged(nameof(Test2));
            }
        }

        public bool ExcludeLowestHighestResult { get; set; } = true;

        public PerformanceTest()
        {
            Test1 = new TestRunner(new ExtensionMethod());
            Test2 = new TestRunner(new Function());
        }

        public void RunTests()
        {
            Test1.RunTest(NumberOfRuns, IterationsPerRun, ExcludeLowestHighestResult);
            Test2.RunTest(NumberOfRuns, IterationsPerRun, ExcludeLowestHighestResult);
        }
    }
}