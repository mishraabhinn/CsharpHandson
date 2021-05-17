using System;
namespace CSharpHandOnPractice.Intermediate.Nullable
{
    public class NullableTpe
    {
        static void Main(string[] args)
        {

        
            Nullable<int> i=null;
            if(i==null)
             Console.WriteLine("Null");
            else
                Console.WriteLine(i);
        }
    }

}