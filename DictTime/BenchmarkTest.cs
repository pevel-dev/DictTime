using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;

namespace Recognizer;

public class BenchmarkTest
{
    [Benchmark(Description = "Range")]
    public void RangeInts()
    {
        
    }
    
    [Benchmark(Description = "Broken")]
    public void BrokenInts()
    {
        
    }
}