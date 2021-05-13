// C# Program to illustrate calling
// a Default constructor
using System;
namespace CSharpHandsOnPractice.ClassAndObjects {

class @Constructor {

	int num;
	string name;

	// this would be invoked while the
	// object of that class created.
	@Constructor()
	{
		Console.WriteLine("Constructor Called");
	}

	// Main Method
	public static void Main()
	{

		// this would invoke default
		// constructor.
		@Constructor @constructor = new @Constructor();

		// Default constructor provides
		// the default values to the
		
		Console.WriteLine(@constructor.name);
		Console.WriteLine(@constructor.num);
	}
}
}
