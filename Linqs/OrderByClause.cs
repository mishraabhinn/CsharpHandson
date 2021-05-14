using System;
using System.Linq;
namespace CSharpHandOnPractice.Linqs
{  
    public static partial class Example
    {
        public static int GetNumbers()
        {
           
            var numbers = new int[] { 9, 1, 5, 8, 6, 7, 3, 2, 0, 4 };

            var query = from number in numbers
                        /* update query here */
                        orderby number 
                        select number;

            return query;
        }

    }
}
    
