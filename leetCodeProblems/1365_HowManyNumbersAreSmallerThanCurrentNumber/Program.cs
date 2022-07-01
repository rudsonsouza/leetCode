using System;

namespace _1365_HowManyNumbersAreSmallerThanCurrentNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = SmallerNumbersThanCurrent(new int[] { 8, 1, 2, 2, 3 });
        }

        static int[] SmallerNumbersThanCurrent(int[] nums)
        {
            int[] res = new int[nums.Length];
            int[] numbers = new int[101];

            for (int i = 0; i < nums.Length; i++)
            {
                numbers[nums[i]]++;
            }

            for (int i = 1; i < 101; i++)
            {
                numbers[i] += numbers[i - 1];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                res[i] = nums[i] == 0 ? 0 : numbers[nums[i] - 1];
            }

            return res;
        }
    }
}
