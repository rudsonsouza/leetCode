using System;
using System.Collections.Generic;
using System.Linq;

namespace _2103_RingsAndRods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = CountPoints("B0B6G0R6R0R6G9");
        }

        static int CountPoints(string rings)
        {
            Dictionary<char, HashSet<char>> freqs = new Dictionary<char, HashSet<char>>();
            int i = 0;
            int count = 0;
            while (i < rings.Length)
            {
                if (freqs.ContainsKey(rings[i + 1]))
                {
                    freqs[rings[i + 1]].Add(rings[i]);
                }
                else
                {
                    HashSet<char> temp = new HashSet<char>();
                    temp.Add(rings[i]);
                    freqs.Add(rings[i + 1], temp);
                }

                i = i + 2;
            }

            foreach (var kvp in freqs)
            {
                if (kvp.Value.Count() == 3) count++;
            }

            return count;
        }
    }
}
