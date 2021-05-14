using System;
using System.Linq;
namespace CSharpHandOnPractice.Linqs
{  
    public static partial class Example
    {
        public static int GetNumbers()
        {
            var numbers = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
           
         var query= 
            from user in numbers
             where user>6
             select user ;
            return (query.Count());
        }

    }
}
    
