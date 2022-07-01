using System;

namespace _1528_ShuffleString
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = RestoreString("codeleet", new int[]{ 4, 5, 6, 7, 0, 2, 1, 3 });
        }

        static string RestoreString(string s, int[] indices)
        {
            char[] res = new char[indices.Length];

            for (int i = 0; i < indices.Length; i++)
            {
                res[indices[i]] = s[i];
            }

            return new string(res);
        }
    }
}
