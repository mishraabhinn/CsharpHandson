using System;

namespace CSharpHandsOnPractice.Delegate
{
    public delegate void delegateAdd(int x, float y, double z);
    public delegate double delegateAddDecimal(int x, float y, double e);
    public delegate bool delegateCheckLength(string name);


    class GenericDelegates
    {
            
       
        public static void add(int x, float y, double z)
        {
            Console.WriteLine(x + y + z);
        }

        public static double addDecimal(int x,float y,double z)
        {
            return x + y + z;
        }

        public static bool checkLenghth(string name)
        {
            if (name.Length > 5)
                return true;
            return false;
        }

        static void Main(string[] args)
        {

            Action<int ,float,double> delegateAddObj = add;
            delegateAddObj.Invoke(8, 8.5f , 100.9);
            Func<int,float,double,double> delegateAddDecimalObj = addDecimal;
            double AddDecimalResult = delegateAddDecimalObj.Invoke(8, 8.5f, 100.9);
            Console.WriteLine(AddDecimalResult);
            Predicate<string> delegateCheckLengthObj = checkLenghth;
            bool checkLengthResult = delegateCheckLengthObj.Invoke("Abhinn");
            Console.WriteLine(checkLengthResult);







        }
    }
}