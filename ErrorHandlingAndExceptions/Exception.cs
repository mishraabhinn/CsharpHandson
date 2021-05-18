using System;
  
namespace ErrorHandlingAndExceptions
{
    class ErrorHandling
    {
        static void Main(string[] args)
        {
            
            string[] name =new string[] {"rahul","abhinn","Random","rohal"};
    
            // Display values of array elements
           foreach(var names in name) {
                Console.WriteLine(names);
            }
    
            try {
    
                
                Console.WriteLine(name[7]);
                
            }
            catch (IndexOutOfRangeException e) {
    
                
                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
        }
    }
}