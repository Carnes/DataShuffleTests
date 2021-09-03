using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using ShuffleSpeedTest.TestPatterns.ClassicSwapTestNs;
using ShuffleSpeedTest.TestPatterns.LinqOrderByRandTestNs;
using ShuffleSpeedTest.TestPatterns.StaticSwapTestNs;
using ShuffleSpeedTest.TestPatterns.TupleSwapTestNs;

namespace ShuffleSpeedTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine($"Warming up..");
            var rand = new Random();
            var testData = RandomDataGenerator.Get();
            var timer = new Stopwatch();

            var tests = new List<IShuffleTest>
            {
                new ClassicSwapTest(),
                new StaticSwapTest(),
                new TupleSwapTest(),
                new LinqOrderByRandTest(),
            };

            for (var i = 0; i < tests.Count; i++)
            {
                Thread.Sleep(2);
                var test = tests[i];
                Console.Write($"Test: {tests[i].GetType().Name}");
                timer.Start();
                var data = test.Run(testData, rand);
                timer.Stop();
                Console.WriteLine($"  -  {timer.Elapsed} elapsed\n");
                timer.Reset();
            }
        }
    }
}