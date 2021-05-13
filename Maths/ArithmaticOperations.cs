// C# program to demonstrate the working
// of Binary Arithmetic Operators
using System;
namespace CSharpHandsOnPractice.Maths
{
	class ArithmaticOperations
	{
		
		// Main Function
		static void Main(string[] args)
		{
			
			int result;
			int x = 15, y = 7;
			
			// Addition
			result = (x + y);
			Console.WriteLine("Addition Operator: " + result);
			
			// Subtraction
			result = (x - y);
			Console.WriteLine("Subtraction Operator: " + result);
			
			// Multiplication
			result = (x * y);
			Console.WriteLine("Multiplication Operator: "+ result);
			
			// Division
			result = (x / y);
			Console.WriteLine("Division Operator: " + result);
			
			// Modulo
			result = (x % y);
			Console.WriteLine("Modulo Operator: " + result);
		}
	}
}
