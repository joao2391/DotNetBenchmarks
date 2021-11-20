using System.Collections.Generic;
using BenchmarkDotNet.Attributes;

namespace DotNet.Benchmarks.DataStructs
{
    [MemoryDiagnoser, RPlotExporter]
    public class CollectionsVersusArraysComparison
    {

        [Benchmark]
        public string[] Array()
        {
            var array = new string[1000];

            for (int i = 0; i < 1000; i++)
            {
                array[i] = "a";
            }

            return array;
        }

        [Benchmark]
        public List<string> List()
        {
            var list = new List<string>();

            for (int i = 0; i < 1000; i++)
            {
                list.Add("a");
            }

            return list;
        }

        [Benchmark]
        public HashSet<string> HashSet()
        {
            var hash = new HashSet<string>();

            for (int i = 0; i < 1000; i++)
            {
                hash.Add("a");
            }

            return hash;
        }

        [Benchmark]
        public Dictionary<int, string> Dictionary()
        {
            var dict = new Dictionary<int, string>();

            for (int i = 0; i < 1000; i++)
            {
                dict.Add(i, "a");
            }

            return dict;
        }

        [Benchmark]
        public LinkedList<string> LinkedList()
        {
            var linked = new LinkedList<string>();

            for (int i = 0; i < 1000; i++)
            {
                linked.AddFirst("a");
            }

            return linked;
        }

        [Benchmark]
        public Queue<string> Queue()
        {
            var queue = new Queue<string>();

            for (int i = 0; i < 1000; i++)
            {
                queue.Enqueue("a");
            }

            return queue;
        }

        [Benchmark]
        public SortedDictionary<int, string> SortedDictionary()
        {
            var dict = new SortedDictionary<int, string>();

            for (int i = 0; i < 1000; i++)
            {
                dict.Add(i, "a");
            }

            return dict;
        }

        [Benchmark]
        public SortedSet<string> Sorted()
        {
            var sorted = new SortedSet<string>();

            for (int i = 0; i < 1000; i++)
            {
                sorted.Add("a");
            }

            return sorted;
        }

        [Benchmark]
        public Stack<string> Stack()
        {
            var stack = new Stack<string>();

            for (int i = 0; i < 1000; i++)
            {
                stack.Push("a");
            }

            return stack;
        }
    }
}
