using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Types
{
    [MemoryDiagnoser, RPlotExporter]
    public class StructComparison
    {
        [Benchmark]
        public ClassToTest ReturnClass()
        {
            var obj = new ClassToTest
            {
                Id = 1,
                Address = "teste",
                Name = "name"
            };

            return obj;
        }

        [Benchmark]
        public StructToTest ReturnStruct()
        {
            var obj = new StructToTest
            {
                Id = 1,
                Address = "teste",
                Name = "name"
            };

            return obj;
        }
    }
}
