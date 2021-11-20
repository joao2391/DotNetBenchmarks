using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Interfaces
{
    [MemoryDiagnoser, RPlotExporter]
    public class InterfaceComparison : ITest
    {
        [Benchmark]
        public int TestInterface()
        {
            int x = 1 + 1;

            return x;
        }

        [Benchmark]
        public int MethodOutInterface()
        {
            int x = 1 + 1;

            return x;
        }
    }

}
