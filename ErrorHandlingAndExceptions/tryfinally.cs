using System;
namespace CSharpHandsOnPractice.ErrorHandlingAndExceptions
{
    class TryFinally {

        static void Main(string[] args)
        {
            int a=5;
            int b=0;
            try
            {
                int result = a/b;
                Console.WriteLine(result);
            }
            
            finally
            {
                Console.WriteLine("Divide By Zero Attempted");
            }
        }	
	}
}
