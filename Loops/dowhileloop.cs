// C# program to illustrate do-while loop
using System;
class dowhileloop
{
	public static void Main()
	{
		int x = 21;
		do
		{
			// The line will be printed even
			// if the condition is false
			Console.WriteLine(x);
			x++;
		}
		while (x < 20);
	}
}
