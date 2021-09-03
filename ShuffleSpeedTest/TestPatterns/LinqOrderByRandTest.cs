using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleSpeedTest.TestPatterns.LinqOrderByRandTestNs
{
    public class LinqOrderByRandTest : IShuffleTest
    {
        public List<RandomData> Run(List<RandomData> data, Random rand)
        {
            return data.OrderBy(x => rand.Next()).ToList();
        }
    }
}