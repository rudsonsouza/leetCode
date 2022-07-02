using System;
using System.Collections.Generic;

namespace _2089_FindTargeIndicesAfterSortingArray
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = TargetIndices(new int[] { 1, 2, 5, 2, 3 }, 2);
        }

        static IList<int> TargetIndices(int[] nums, int target)
        {
            List<int> result = new List<int>();
            int lessCount = 0;
            int equalCount = 0;

            foreach(int num in nums)
            {
                if (num == target)
                    equalCount++;
                else if (num < target)
                    lessCount++;
            }

            for (int i = 0; i < equalCount; i++)
            {
                result.Add(lessCount++);
            }

            return result;
        }
    }
}

