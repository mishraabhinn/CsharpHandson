using System;

namespace CSharpHandsOnPractice.Delegate
{
    public delegate void DelegateAreaPermeter(int x, int y);           

    class MulicastDelegateDemo
    {
         
        public void GetArea(int width,int length)
        {
            Console.WriteLine(width * length);
        }
        public void GetPerimeter(int width, int length)
        {
            Console.WriteLine(2*(width +length));
        }
        static void Main(string[] args)
        {
            var obj = new MulicastDelegateDemo();
            DelegateAreaPermeter delegateObj = new DelegateAreaPermeter(obj.GetArea);
            delegateObj += obj.GetPerimeter;
            delegateObj.Invoke(10, 20);

        }
    }
}