using System;
using System.Collections.Generic;

namespace _346_MovingAverageDataStream
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            MovingAverage obj = new MovingAverage(3);
            double param_1 = obj.Next(1);
            double param_2 = obj.Next(10);
            double param_3 = obj.Next(3);
            double param_4 = obj.Next(5);
        }
    }

    public class MovingAverage
    {
        public Queue<double> Window;
        public int Size;
        public double CurSum;

        public MovingAverage(int size)
        {
            Window = new Queue<double>();
            Size = size;
            CurSum = 0;
        }

        public double Next(int val)
        {
            Window.Enqueue(val);
            CurSum += val;

            if (Window.Count > Size)
            {
                CurSum = CurSum - Window.Dequeue();
                return CurSum / Size;
            }
            else
            {
                return CurSum / Window.Count;
            }
        }
    }
}

