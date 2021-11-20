using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Interfaces
{
    [MemoryDiagnoser, RPlotExporter]
    public class TestWithoutInterface
    {

        [Benchmark]
        public int TestOutInterface()
        {
            int x = 1 + 1;

            return x;
        }
    }
}
