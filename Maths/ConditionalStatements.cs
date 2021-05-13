using System;
namespace CSharpHandsOnPractice.Maths {
      
class ConditionalStatements {
      
    // Main Function
    static void Main(string[] args)
    {
            int x = 4, y = 8, result;
              
            // To find which value is greater
            // Using Conditional Operator
            result = x > y ? x : y; 
              
            // To display the result 
            Console.WriteLine("Result: " + result);
              
            // To find which value is greater
            // Using Conditional Operator
            result = x < y ? x : y; 
              
            // To display the result
            Console.WriteLine("Result: " + result);
    }
}
}