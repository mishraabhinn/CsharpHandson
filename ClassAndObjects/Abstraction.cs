using System;
namespace CSharpHandsOnPractice.ClassAndObjects
{
    public abstract class  AbstractDemo
    {
        
        public abstract double areaofcircle();
    }


    public class InheritDemoAbstract:AbstractDemo
    {
        private int Radius;
        public InheritDemoAbstract(int radius=0)
        {   
            Radius=radius;
        }
        
        
        public override double areaofcircle()
        {   
            Console.Write("Area =:");
            return(3.14*Radius*Radius);
        }
        
    }

    public class DriverClass
    {
        static void Main(string[] agrs)
        {
        AbstractDemo obj=new InheritDemoAbstract(4);
        double area=obj.areaofcircle();
        Console.Write(area);
        }
        
        
    }

}



