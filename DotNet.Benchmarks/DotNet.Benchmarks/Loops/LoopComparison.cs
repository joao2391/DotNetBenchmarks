using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Loops
{
    [MemoryDiagnoser, RPlotExporter]
    public class LoopComparison
    {
        [Benchmark]
        public int While()
        {
            int count = 0;

            while (count < 1000)
            {
                count++;
            }

            return count;
        }

        [Benchmark]
        public int For()
        {
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                count++;
            }

            return count;
        }

        [Benchmark]
        public int DoWhile()
        {
            int count = 0;

            do
            {
                count++;

            } while (count < 1000);

           
            return count;
        }

    }
}
