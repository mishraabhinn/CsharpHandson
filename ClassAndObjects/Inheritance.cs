// C# program to illustrate the
// concept of inheritance
using System;
namespace CSharpHandsOnPractice {

// Base class
class Information{


	public string name;
	public string positon;

	// public method of base class
	public void readers(string name, string position)
	{
		this.name = name;
		this.positon = positon;
		Console.WriteLine("Myself: " + name);
		Console.WriteLine("I am  " + position);
	}
}

// inheriting the Information class using :
class InheritedInformation : Information {

	// constructor of derived class
	public InheritedInformation()
	{
		Console.WriteLine("Constructor Of Child Class Called");
	}
}

// Driver class
class Inheritance {

	// Main Method
	static void Main(string[] args)
	{

		// creating object of derived class
		InheritedInformation g = new InheritedInformation();

		// calling the method of base class
		// using the derived class object
		g.readers("Abhinn", "Junior Software Developer");
	}
}
}
