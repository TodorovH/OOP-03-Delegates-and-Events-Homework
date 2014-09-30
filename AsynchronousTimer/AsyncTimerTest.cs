using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsynchronousTimer
{
    class AsyncTimerTest
    {
        static void Main(string[] args)
        {
            AsyncTimer first = new AsyncTimer(FirstTimer, 10, 1000);
            first.Start();
            AsyncTimer second = new AsyncTimer(SecondTimer, 5, 5000);
            second.Start();
        }

        public static void FirstTimer(string str)
        {
            Console.WriteLine(str);
            Console.WriteLine();
        }

        public static void SecondTimer(string str)
        {
            Console.WriteLine("I am the second timer!");
            Console.WriteLine();
        }
    }
}
