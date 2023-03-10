using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Recognizer;

public class BenchmarkTest
{
    [Benchmark(Description = "Range")]
    public void RangeInts()
    {
        var d = new Dictionary<int, int>();
        for (var i = 0; i < 50000; i++)
        {
            d[i] = 0;
        }
    }
    
    [Benchmark(Description = "Broken")]
    public void BrokenInts()
    {
        var d = new Dictionary<int, int>();
        var i = 0;
        var current = 0;
        while (i < 50000)
        {
            current = HashHelper.GetPrime(current) + 1;
            d[current] = 0;
            i++;
        }
    }
}