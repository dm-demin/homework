namespace ParallelCalculationTests;

public class CalculateTest_100K : CalculateTestBase
{
    public CalculateTest_100K()
        : base(MatrixGenerator.GetRandomInts(100000))
    {
    }
}
