using System;

namespace CSharpHandsOnPractice.Delegate
{
    public delegate void AddDelegate(int x, int y);
    public delegate void SayHelloDelegate(string str);
                

    class DelegateDemo
    {
         
        public void add(int num1,int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        public static void SayHello(string str)
        {
            Console.WriteLine("Hello: " + str);
        }
        static void Main(string[] args)
        {
            var obj = new DelegateDemo();
            AddDelegate delgateObj = new AddDelegate(obj.add);
            delgateObj.Invoke(10, 18);
            SayHelloDelegate delegateSayHelloObj = new SayHelloDelegate(DelegateDemo.SayHello);
            delegateSayHelloObj.Invoke("Abhinn");
            
        }
    }
}