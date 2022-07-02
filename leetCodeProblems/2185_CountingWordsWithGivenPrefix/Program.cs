﻿using System;

namespace _2185_CountingWordsWithGivenPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int PrefixCount(string[] words, string pref)
        {
            int counter = 0;
            string wordPref = "";
            for (int i = 0; i < words.Length; i++)
            {
                wordPref = words[i].Length >= pref.Length ? words[i].Substring(0, pref.Length) : words[i];
                if (wordPref == pref)
                    counter++;
            }

            return counter;
        }
    }
}

