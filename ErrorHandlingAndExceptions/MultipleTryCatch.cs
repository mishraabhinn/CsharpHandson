using System;
namespace CSharpHandsOnPractice.ErrorHandlingAndExceptions
{
    class MultipleTryCatch {

        static void Main(string[] args)
        {
            int[] arr = new int[] {1,2,3,0};

            try {


                for (int i = 0; i < arr.Length; i++) {
                    Console.WriteLine(arr[i] / arr[i + 1]);
                }
            }

            
            catch (IndexOutOfRangeException e) {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            
            catch (DivideByZeroException e) {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }

            
            catch (ArgumentOutOfRangeException e) {

                Console.WriteLine("An Exception has occurred : {0}", e.Message);
            }
        }	
	}
}
