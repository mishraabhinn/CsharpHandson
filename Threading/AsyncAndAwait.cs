using System;
using System.Threading;

namespace CSharpHandsOnPractice.Threading
{
    class AsyncAndAwait
    {
        static void Main(string[] args)
        {
            Method();
            Console.WriteLine("Main thread");
            Console.ReadLine();
        }
        
        public static async void Method()
        {
            await Task.Run(new Action(LongTask));
            Console.WriteLine("New Thread"); //wait until the long task finishes. 
        }
        Public static void LongTask()
        {
            Thread.Sleep(20000);
        }
    }
    
}
