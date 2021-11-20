using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Types
{
    [MemoryDiagnoser, RPlotExporter]
    public class ObjectComparison
    {
        [Benchmark]
        public object ReturnObject()
        {
            var obj = new ClassToTest
            {
                Id = 1, Address = "teste", Name = "name"
            };

            return obj;
        }

        [Benchmark]
        public dynamic ReturnDynamic()
        {
            var dyn = new ClassToTest
            {
                Id = 1,
                Address = "teste",
                Name = "name"
            };

            return dyn;
        }

        [Benchmark]
        public ClassToTest ReturnClass()
        {

            var cls = new ClassToTest
            {
                Id = 1,
                Address = "teste",
                Name = "name"
            };

            return cls;
        }
    }
}
