using System;
namespace CSharpHandsOnPractice.ClassAndObjects
{
class MethodOverLoading {

	// adding three integer values.
	public int Add(int a, int b, int c)
	{
		int sum = a + b + c;
		return sum;
	}

	// adding three double values.
	public double Add(double a,
					double b, double c)
	{
		double sum = a + b + c;
		return sum;
	}

	// Main Method
	public static void Main(String[] args)
	{

		// Creating Object
		MethodOverLoading obj = new MethodOverLoading();
		//Returned sum	
		int sum2 = obj.Add(1, 2, 3);
		Console.WriteLine("sum of the three "
						+ "integer value : " + sum2);
		double sum3 = obj.Add(1.0, 2.0, 3.0);
		Console.WriteLine("sum of the three "
						+ "double value : " + sum3);
	}
}
}
