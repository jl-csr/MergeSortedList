using System;
using System.Collections.Generic;

namespace MergeSortedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstList = new List<int> { 0, 2, 4, 7, 9 };
            var secondList = new List<int> { 1, 3, 5, 6, 8, 10 };
            var merge = new List<int> { };
            var firstIndex = 0;
            var secondIndex = 0;

            while (firstIndex < firstList.Count && secondIndex < secondList.Count)
            {
                if (firstList[firstIndex] < secondList[secondIndex])
                {
                    merge.Add(firstList[firstIndex++]);
                }
                else
                {
                    merge.Add(secondList[secondIndex++]);
                }
            }

            if (firstIndex < firstList.Count)
            {
                for (int a = firstIndex; a < firstList.Count; a++)
                {
                    merge.Add(firstList[a]);
                }
            }

            if (secondIndex < secondList.Count)
            {
                for (int a = secondIndex; a < secondList.Count; a++)
                {
                    merge.Add(secondList[a]);
                }
            }

            Console.WriteLine(Newtonsoft.Json.JsonConvert.SerializeObject(merge));
            Console.ReadKey();
        }
    }
}
