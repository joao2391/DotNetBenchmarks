using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Tasks
{
    [MemoryDiagnoser, RPlotExporter]
    public class ConfigureAwaitComparison
    {
        [Benchmark]
        public async Task<int> ConfigureAwaitFalse()
        {

            var t = await Task.Run(() => RunForF()).ConfigureAwait(false);

            return t;

        }

        public int RunForF()
        {
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                count = i;
            }

            return count;
        }

        [Benchmark]
        public async Task<int> ConfigureAwaitTrue()
        {

            var t = await Task.Run(() => RunForT()).ConfigureAwait(true);

            return t;

        }

        public int RunForT()
        {
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                count = i;
            }

            return count;
        }


    }
}
