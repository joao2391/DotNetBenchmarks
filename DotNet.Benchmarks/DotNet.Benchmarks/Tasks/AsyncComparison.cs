using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.Tasks
{

    [MemoryDiagnoser, RPlotExporter]
    public class AsyncComparison
    {

        [Benchmark]
        public async Task<int> TaskRun_WithAwait()
        {
            var t = await Task.Run(() => RunForC());

            return t;

        }

        public int RunForC()
        {
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                count = i;
            }

            return count;
        }

        public int RunForS()
        {
            int count = 0;

            for (int i = 0; i < 1000; i++)
            {
                count = i;
            }

            return count;
        }

        [Benchmark]
        public int TaskRun_WithoutAwait()
        {
            var t = Task.Run(() => RunForS()).Result;

            return t;

        }

        //[Benchmark]
        //public async Task<HttpResponseMessage> HttpClientWithAwait()
        //{
        //    var client = new HttpClient();

        //    var result = await client.GetAsync("https://www.google.com.br/");

        //    return result;

        //}

        //[Benchmark]
        //public HttpResponseMessage HttpClientWithoutAwait()
        //{
        //    var client = new HttpClient();

        //    var result = client.GetAsync("https://www.google.com.br/").Result;

        //    return result;

        //}
    }
}
