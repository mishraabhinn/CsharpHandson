using System;
namespace CSharpHandsOnPractice.Maths {
	
	class LogicalOperators {
		
		// Main Function
		static void Main(string[] args)
		{
			
			int a=10;
            int b=10;
            

			// post-increment example:
			// res is assigned 10 only,
			// a is not updated yet
			if(a==b)
            {
                Console.WriteLine("Equal");
            }
			
			else if(a!=b)
            {
                Console.WriteLine("Not Equal");
            }



			
		}
	}
}
