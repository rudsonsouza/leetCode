using System;
using System.Collections.Generic;

namespace _359_LoggerRateLimiter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Logger
    {
        Dictionary<string, int> msgTimeStampTracker;

        public Logger()
        {
            this.msgTimeStampTracker = new Dictionary<string, int>();
        }

        public bool ShouldPrintMessage(int timestamp, string message)
        {
            if (!msgTimeStampTracker.ContainsKey(message))
            {
                msgTimeStampTracker.Add(message, timestamp + 10);
                return true;
            }
            else
            {
                if (msgTimeStampTracker[message] <= timestamp)
                {
                    msgTimeStampTracker[message] = timestamp + 10;
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}

