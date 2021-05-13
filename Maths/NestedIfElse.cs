// C# example for switch case
using System;
namespace CSharpHandsOnPractice.Maths{
public class NestedIfElse 
{
    public static void Main(String[] args)
    {
        int a=10;
        if(a<20)
        {
            if(a%2==0)
            {
                Console.WriteLine("Number is less than twenty and is even");
            }
            else
            {
                Console.WriteLine("Number is less than twenty and is odd");
            }
        }
        else
        {
            Console.WriteLine("Number is greater than twenty");
        }
    }
}
}