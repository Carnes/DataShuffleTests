using System;
using System.Collections.Generic;

namespace ShuffleSpeedTest
{
    public interface IShuffleTest
    {
        List<RandomData> Run(List<RandomData> data, Random rand);
    }
}