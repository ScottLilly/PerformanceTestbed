# PerformanceTestbed

This is a simple testbed program, to compare the performance of different coding techniques (for example, is a "switch" statement faster than a series of "if...else if" statements).

NOTE: This currently only works to compare two different techniques.

To use it:
1. Create a new folder under the Engine\Tests folder.
2. Create two classes that implement the IScenario interface - one class for each technique.
3. Edit Engine\ViewModels\PerformaceTest.cs.
4. Change the constructor to instantiate new TestRunner objects, using the the two IScenario classes.
5. Run the test.
