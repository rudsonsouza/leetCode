using System;

namespace _1313_DecompressRunLengthEncodedList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = DecompressRLElist(new int[] { 1, 2, 3, 4 });
        }

        static int[] DecompressRLElist(int[] nums)
        {
            var length = 0;
            for (int i = 0; i < nums.Length / 2; i++)
            {
                length += nums[2 * i];
            }

            var array = new int[length];
            var step = 0;

            for (int i = 0; i < nums.Length / 2; i++)
            {
                array[step] = nums[2 * i + 1];
                step += nums[2 * i];
            }

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] == 0)
                {
                    array[i] = array[i - 1];
                }
            }

            return array;
        }
    }
}
