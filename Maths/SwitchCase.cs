// C# example for switch case
using System;
namespace CSharpHandsOnPractice.Maths{


public class SwitchCase 
{
    public static void Main(String[] args)
    {
        int number = 5;
        switch(number)
        {
        case 1: Console.WriteLine("case 1");
                 break;

        case 2: Console.WriteLine("case 2");
                 break;

        case 3: Console.WriteLine("case 3");
                 break;
                 
        case 4: Console.WriteLine("case 4");
                 break;

        case 5: Console.WriteLine("case 5");
                 break;

        default: Console.WriteLine("None matches"); 
                 break;
        }
    }
}
}