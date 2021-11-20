using System;
using BenchmarkDotNet.Running;
using DotNet.Benchmarks.DataStructs;

namespace DotNet.Benchmarks
{
    class Program
    {
        static void Main(string[] args)
        {
            //BenchmarkRunner.Run<CollectionsVersusArraysComparison>();
            //BenchmarkRunner.Run<String.StringComparison>();
            //BenchmarkRunner.Run<String.StringMethods>();
            //BenchmarkRunner.Run<Loops.LoopComparison>();
            //BenchmarkRunner.Run<Loops.ForVersusForeach>();
            //BenchmarkRunner.Run<Tasks.AsyncComparison>();
            //BenchmarkRunner.Run<Tasks.ConfigureAwaitComparison>();
            //BenchmarkRunner.Run<Tasks.AwaitComparison>();
            //BenchmarkRunner.Run<Interfaces.InterfaceComparison>();
            //BenchmarkRunner.Run<Types.ObjectComparison>();
            BenchmarkRunner.Run<Types.StructComparison>();



            Console.ReadKey();
        }
    }
}
