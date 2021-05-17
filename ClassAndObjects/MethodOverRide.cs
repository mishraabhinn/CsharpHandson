using System;
namespace CSharpHandsOnPractice.ClassAndObjects
{
class MethodOverLoading
 {	
	public virtual void methodoverride()
	{
		Console.WriteLine("Method");
	}

}
class driver:MethodOverLoading
{
    public override void methodoverride()
    {
        Console.WriteLine("OverRidden Sucessfully");
    }
    // Main Method
	public static void Main(String[] args)
	{

		// Creating Object
		driver obj = new driver();
		obj.methodoverride();
		
	}
}
}
