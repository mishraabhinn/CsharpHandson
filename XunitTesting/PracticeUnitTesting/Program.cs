using System;

namespace abhinn
{
    public class Program
    {
        public bool isvalid(string s1,string s2 )
        {
            if (s1 == s2)
                return true;
            else
                return false;
        }
        static void Main(string[] args)
        {

            //var obj = new Program();
            //bool ans =obj.isvalid("s1", "s1");
            //Console.WriteLine(ans);
            
            string author1 = "s1";
            string author2 = "s2";

            // Use String.Compare method  
            if (String.Compare(author1, author2) == 0)
                Console.WriteLine($"Both strings have same value.");
            else if (String.Compare(author1, author2) < 0)
                Console.WriteLine($"{author1} precedes {author2}.");
            else if (String.Compare(author1, author2) > 0)
                Console.WriteLine($"{author1} follows {author2}.");


        }
    }
}
