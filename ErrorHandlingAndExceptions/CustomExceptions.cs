using System;
namespace CSharpHandsOnPractice.ErrorHandlingAndExceptions
{

    class DivByZero : Exception 
    {

        
        public DivByZero()
        {
            Console.Write("Exception has occurred : ");
        }
    }

    class Program 
    {

        
        public double DivisionOperation(double numerator,
                                    double denominator)
        {
            // throw exception when denominator
            // value is 0
            if (denominator == 0)
                throw new DivByZero();

            // Otherwise return the result of the division
            return numerator / denominator;
        }

        // Main
        static void Main(string[] args)
        {
            Program obj = new Program();
            double num = 9, den = 0, quotient;
            try {
                // Code block that may cause an exception
                quotient = obj.DivisionOperation(num, den);
                Console.WriteLine("Quotient = {0}", quotient);
            }
            // Catch block to catch the generic exception
            catch (Exception e) {
                
                Console.Write(e.Message);
            }
        }
    }
}
