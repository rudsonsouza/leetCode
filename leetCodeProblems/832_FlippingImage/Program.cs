using System;

namespace _832_FlippingImage
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }

        static int[][] FlippingImage(int[][] image)
        {
            for (int i = 0; i < image.Length; i++)
            {
                image[i] = reverseToggle(image[i]);

            }

            return image;
        }

        static int[] reverseToggle(int[] arr)
        {
            int[] result = new int[arr.Length];
            int x = 0;

            for (int i = arr.Length - 1; i >= 0; i--)
            {
                result[x] = arr[i] == 0 ? 1 : 0;
                x++;
            }

            return result;
        }

    }
}

