using System;
using System.Threading.Tasks;

namespace CSharpHandsOnPractice.Threading
{
    class AsyncvsThread
    {
        static void Main(string[] args)
        {
            SomeMethod();
            Console.WriteLine("Main Method Finished");

        }      
        static async void SomeMethod()
        {
            await Task.Delay(20000);
            Console.WriteLine("SomeMethod Finished");
        }
    }
}