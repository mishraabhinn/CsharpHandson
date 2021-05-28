using System;

namespace CSharpHandsOnPractice.Delegate
{
    public delegate void DelegateSayHello(string name);           

    class AsyncronousDelegateDemo
    {
        static void Main(string[] args)
        {
            var obj = new AsyncronousDelegateDemo();
            DelegateSayHello delegateObj = delegate (string name)
            {
                Console.WriteLine("Hello: " + name);
            };
            delegateObj.Invoke("ABHINN");

        }
    }
}