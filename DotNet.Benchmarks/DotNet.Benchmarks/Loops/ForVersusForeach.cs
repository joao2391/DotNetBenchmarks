using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Loops
{
    [MemoryDiagnoser, RPlotExporter]
    public class ForVersusForeach
    {

        [Benchmark]
        public int ForeachIntegerList()
        {
            var list = new List<int>();
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }

            foreach (var item in list)
            {
                count = item;
            }

            return count;

        }

        [Benchmark]
        public int ForIntegerList()
        {
            var list = new List<int>();
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                list.Add(i);
            }

            for (int i = 0; i < list.Count; i++)
            {
                count = list[i];
            }

            return count;

        }

        [Benchmark]
        public string ForeachStringList()
        {
            var list = new List<string>();
            string str = "";

            for (int i = 0; i < 1000; i++)
            {
                list.Add("a");
            }

            foreach (var item in list)
            {
                str = item;
            }

            return str;

        }        

        [Benchmark]
        public string ForStringList()
        {
            var list = new List<string>();
            string str = "";

            for (int i = 0; i < 1000; i++)
            {
                list.Add("a");
            }

            for (int i = 0; i < list.Count; i++)
            {
                str = list[i];
            }

            return str;

        }
    }
}
