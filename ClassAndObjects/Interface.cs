using System;
namespace CSharpHandOnPractice.ClassAndObjects
{
    interface Interface
    {
        void add(int x,int y);
    }
    
    class driver:Interface
    {
        public void add(int x, int y)
        {
            Console.WriteLine(x+y);
        }
        static void Main()
        {
            var obj=new driver();
            obj.add(8,2);
        }
    }
}