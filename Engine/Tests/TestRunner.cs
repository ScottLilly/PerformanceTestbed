using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;

namespace Engine.Tests
{
    public class TestRunner : BaseNotificationClass
    {
        private readonly Stopwatch _stopwatch = new Stopwatch();
        private bool _excludeLowestHighestResult;
        private int _iterationsPerRun;
        private int _numberOfRuns;

        private IScenario _scenario;

        public IScenario Scenario
        {
            get => _scenario;
            private set
            {
                _scenario = value;
                OnPropertyChanged(nameof(Scenario));
            }
        }

        public ObservableCollection<TestResult> Results { get; }

        public long TotalTicks => _excludeLowestHighestResult
                                      ? Results.Sum(result => result.NumberOfTicks) -
                                        Results.Min(result => result.NumberOfTicks) -
                                        Results.Max(result => result.NumberOfTicks)
                                      : Results.Sum(result => result.NumberOfTicks);

        public decimal AverageTicksPerRun => _numberOfRuns <= 2
                                                 ? 0
                                                 : Convert.ToDecimal(TotalTicks) /
                                                   Convert.ToDecimal(_excludeLowestHighestResult
                                                                         ? _numberOfRuns - 2
                                                                         : _numberOfRuns);

        public TestRunner(IScenario scenario)
        {
            Scenario = scenario;

            Results = new ObservableCollection<TestResult>();
        }

        public void RunTest(int numberOfRuns, int iterationsPerRun, bool excludeLowestHighestResult)
        {
            _numberOfRuns = numberOfRuns;
            _iterationsPerRun = iterationsPerRun;
            _excludeLowestHighestResult = excludeLowestHighestResult;

            Results.Clear();

            for(int run = 0; run < _numberOfRuns; run++)
            {
                _stopwatch.Restart();

                for(int iteration = 0; iteration < _iterationsPerRun; iteration++)
                {
                    Scenario.Execute();
                }

                _stopwatch.Stop();

                Results.Add(new TestResult(run, _stopwatch.ElapsedTicks));
            }

            OnPropertyChanged(nameof(TotalTicks));
            OnPropertyChanged(nameof(AverageTicksPerRun));
        }
    }
}