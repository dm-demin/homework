namespace ParallelCalculationTests;

public class CalculateTest_1M : CalculateTestBase
{
    public CalculateTest_1M()
        : base(MatrixGenerator.GetRandomInts(1000000))
    {
    }
}
