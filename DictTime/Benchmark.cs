using BenchmarkDotNet.Columns;
using BenchmarkDotNet.Configs;
using BenchmarkDotNet.Loggers;
using BenchmarkDotNet.Running;
using BenchmarkDotNet.Validators;
using NUnit.Framework;

namespace Recognizer
{
    [TestFixture]
    public class TestClass
    {
        [Test]
        public void TestMethod1()
        {            
            var config = new ManualConfig()
                .WithOptions(ConfigOptions.DisableOptimizationsValidator)
                .AddValidator(JitOptimizationsValidator.DontFailOnError)
                .AddLogger(ConsoleLogger.Default)
                .AddColumnProvider(DefaultColumnProviders.Instance);
            BenchmarkRunner.Run<BenchmarkTest>(config);
        }
    }
}