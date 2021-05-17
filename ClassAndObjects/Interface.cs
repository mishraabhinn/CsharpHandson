using System;
namespace CSharpHandOnPractice.ClassAndObjects
{
    interface Interface
    {
        void add(int x,int y);
    }
    
    class driver:Interface
    {   string name;
        public driver(string name)
        {
            this.name=name;

        }
        public void add(int x, int y)
        {
            Console.WriteLine(name+"="+x+y);
        }
        static void Main()
        {
            var obj=new driver("Add");
            obj.add(8,2);
        }
    }
}