using System;
namespace CSharpHandsOnPractice.Loops
{
    class whileLoopDemo
    {
        public static void Main()
        {
            int x = 1;
    
            // Exit when x becomes greater than 4
            while (x <= 4)
            {
                Console.WriteLine("Abhinn Mishra "+x);
    
                // Increment the value of x for
                // next iteration
                x++;
            }
        }
    }
}