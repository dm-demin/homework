namespace ParallelCalculationTests;

public static class MatrixGenerator
{
    public static int[] GetRandomInts(int size)
    {
        var rnd = new Random();
        var result = new int[size];
        for (var i = 0; i < result.Length; i++)
        {
            result[i] = rnd.Next(0, 10);
        }

        return result;
    }
}
