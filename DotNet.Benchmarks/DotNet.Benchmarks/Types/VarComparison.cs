using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Types
{
    [MemoryDiagnoser, RPlotExporter]
    public class VarComparison
    {
        [Benchmark]
        public int Int()
        {
            int x = 0;

            return x;
        }


        [Benchmark]
        public int Var()
        {
            var x = 0;

            return x;
        }
    }
}
