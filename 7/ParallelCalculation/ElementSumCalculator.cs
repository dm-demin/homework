namespace ParallelCalculation;

public static class ElementSumCalculator
{
    public static double CalculateSequently(int[] ints)
    {
        var sum = 0;
        for (int i = 0; i < ints.Length; i++)
        {
            sum += ints[i];
        }

        return sum;
    }

    public static double CalculateParallelTread(int[] ints)
    {
        long sum = 0;
        var intsList = ints.ToList<int>;
        Parallel.For<long>(0, ints.Length, () => 0,
            (i, loop, sub) =>
            {
                sub += ints[i];
                return sub;
            },
            sub => Interlocked.Add(ref sum, sub));

        return sum;
    }

    public static double CalculateParallelLinq(int[] ints)
    {
        return ints.AsParallel().Sum(x => x);
    }
}
