using System.Windows;
using Engine.ViewModels;

namespace PerformanceTestbed
{
    public partial class MainWindow : Window
    {
        private readonly PerformanceTest _test = new PerformanceTest();

        public MainWindow()
        {
            InitializeComponent();

            DataContext = _test;
        }

        private void RunTest_OnClick(object sender, RoutedEventArgs e)
        {
            _test.RunTests();
        }
    }
}