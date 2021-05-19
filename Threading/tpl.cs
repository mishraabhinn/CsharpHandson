using System;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpHandsOnPractice.Threading
{
    class tpl
    {
        static void Main(string[] args)
        {
            //Thread obj1 = new Thread(function1);
            //obj1.Start();
            Parallel.For(0, 1000000, x => function1());

            static void function1()
            {
                string x = "";
                for (int i = 0; i < 1000000; i++)
                {
                    x +="s";
                    
                }
            }
            
        }
    }
    
}
