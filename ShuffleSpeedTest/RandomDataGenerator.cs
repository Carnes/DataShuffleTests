using System;
using System.Collections.Generic;

namespace ShuffleSpeedTest
{
    public class RandomDataGenerator
    {
        public static List<RandomData> Get()
        {
            var rndData = new List<RandomData>();
            for(var i = 0; i<10000000; i++)
                rndData.Add(new RandomData());
            return rndData;
        }
    }

    public class RandomData
    {
        public Guid ID = Guid.NewGuid();
    }
}