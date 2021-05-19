using System;
using System.Threading;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Thread obj1 = new Thread(function1);
            Thread obj2 = new Thread(function2);
            obj1.Start();
            obj2.Start();

            static void function1()
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Thread1 executed {i} times");
                    Thread.Sleep(1000);
                }
            }
            static void function2()
            {
                for (int i = 0; i < 4; i++)
                {
                    Console.WriteLine($"Thread2 executed {i} times");
                    Thread.Sleep(1000);
                }
            }
        }
    }
    
}
