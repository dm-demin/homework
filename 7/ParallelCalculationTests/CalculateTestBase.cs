using System.Diagnostics;
using ParallelCalculation;

namespace ParallelCalculationTests;

public abstract class CalculateTestBase
{
    private readonly Stopwatch _stopwatch;

    private readonly int[] _ints;
    private readonly double _sum;

    public CalculateTestBase(int[] ints)
    {
        _ints = ints;
        _sum = _ints.Sum();
        _stopwatch = new Stopwatch();
    }

    [SetUp]
    public void SetUp() => _stopwatch.Reset();

    [TearDown]
    public void TearDown()
    {
        _stopwatch.Stop();
        Console.WriteLine("Execution time was {0} ms", _stopwatch.ElapsedMilliseconds);
    }

    [Test]
    public void TestSequential()
    {
        Console.WriteLine("Execute sequently");
        _stopwatch.Start();
        var sum = ElementSumCalculator.CalculateSequently(_ints);
        _stopwatch.Stop();
        Assert.That(_sum, Is.EqualTo(sum));
    }

    [Test]
    public void TestParallelThread()
    {
        Console.WriteLine("Execute in parallel");
        _stopwatch.Start();
        var sum = ElementSumCalculator.CalculateParallelTread(_ints);
        _stopwatch.Stop();
        Assert.That(_sum, Is.EqualTo(sum));
    }

    [Test]
    public void TestParallelLINQ()
    {
        Console.WriteLine("Execute in parallel using LINQ");
        _stopwatch.Start();
        var sum = ElementSumCalculator.CalculateParallelLinq(_ints);
        _stopwatch.Stop();
        Assert.That(_sum, Is.EqualTo(sum));
    }
}
