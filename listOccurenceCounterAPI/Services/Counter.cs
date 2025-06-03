using System;
using System.Collections.Generic;

namespace listOccurrenceCounterAPI.Services

{
    public static class Counter
    {
        public static Dictionary<T, int> CountOccurrences<T>(List<T> items)
        {
            var countMap = new Dictionary<T, int>();

            foreach (var item in items)
            {
                if (countMap.ContainsKey(item))
                    countMap[item]++;
                else
                    countMap[item] = 1;
            }

            return countMap;
        }
    }
}
