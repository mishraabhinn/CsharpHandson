using System;
namespace CSharpHandsOnPractice.ClassAndObjects
{
class MethodHiding
 {	
	public void methodhide()
	{
		Console.WriteLine("Method");
	}

}
class driver:MethodHiding
{
    public new void methodhide() //Method can be re-implemented using new keyword if not declared as virtual
    {
        Console.WriteLine("Hidden Sucessfully");
    }
    // Main Method
	public static void Main(string[] args)
	{

		// Creating Object
		driver obj = new driver();
		obj.methodhide();
		
	}
}
}
