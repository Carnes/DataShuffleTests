using System;
using System.Collections.Generic;
using System.Linq;

namespace ShuffleSpeedTest.TestPatterns.StaticSwapTestNs
{
    
    public class StaticSwapTest : IShuffleTest
    {
        public List<RandomData> Run(List<RandomData> data, Random rand)
        {
            data.Shuffle(rand);
            return data;
        }        
    }
    
    public static class StaticListExtensions
    {
        public static T Pop<T>(this List<T> list)
        {
            const int index = 0;
            if (!list.Any())
                return default(T);
            T r = list[index];
            list.RemoveAt(index);
            return r;
        }

        public static void Shuffle<T>(this List<T> list, Random rand)
        {
            for (var i = list.Count; i > 0; i--)
                list.Swap(0, rand.Next(0, i));
        }

        private static Object _tempVal; 
        public static void Swap<T>(this List<T> list, int i, int j)
        {
            _tempVal = list[i];
            list[i] = list[j];
            list[j] = (T)_tempVal;
        }
    }    
}