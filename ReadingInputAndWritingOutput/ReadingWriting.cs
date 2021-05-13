//Reading Input and Writing Output at compile time
using System;
namespace CSharpHandsOnPractice.Maths.ReadingAndWritingOutput{
class ReadingWriting 
    {
      
        // only declaration, compiler will 
        // provide the default value 0 to it
        int y;
      
    // Main Method
        public static void Main(String []args)
        {
                
            // Compile Time Initialization of variable 'x'
            // Assigning value 32 to x
            int x = 32;    
                
            // printing the value
            Console.WriteLine("Value of x is "+x);
                
            // creating object to access
            // the variable y
            ReadingWriting readingAndWriting= new ReadingWriting(); 
                
            // printing the value
            Console.WriteLine("Value of y is "+readingAndWriting.y);
        }
    }

}
