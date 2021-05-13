// C# program to illustrate the
// Initialization of an object
using System;
namespace CSharpHandsOnPractice.ClassAndObjects
{
// Class Declaration
public class Human 
    {

        // Instance Variables
        String name;
        
        int age;
        String color;

        // Constructor Declaration of Class
        public Human(String name,int age, String color)
        {
            this.name = name;
            this.age = age;
            this.color = color;
        }

        // Property 1
        public String getName()
        {
            return name;
        }

        // Property 2
        public int getAge()
        {
            return age;
        }

        // Property 3
        public String getColor()
        {
            return color;
        }

        // Method 1
        public String toString()
        {
            return ("Hi my name is " + this.getName() + ".\nMy age and color are " +", " + this.getAge() + ", " + this.getColor());
        }

    // Main Method
    public static void Main(String[] args)
        {
            
            // Creating object
            Human abhinn = new Human("abhinn mishra",22,"brown");
            Console.WriteLine(abhinn.toString());
        }
    }
}
