namespace ParallelCalculationTests;

public class CalculateTest_10M : CalculateTestBase
{
    public CalculateTest_10M()
        : base(MatrixGenerator.GetRandomInts(10000000))
    {
    }
}
