using System;
namespace CSharpHandsOnPractice.ClassAndObjects{
    public class EncapsulatedClass
    {
        private string Name;
        private string Profile;

        public string name
        {
            get{    
                return Name;
                }
            set
            {
                Name=value;
            }
        }
        public string profile
        {
            get{    
                return Profile;
                }
            set
            {
                Profile=value;
            }
        }
    }
      
    class Encapsulation
    {
        static public void Main(string[] args)
        {
            EncapsulatedClass obj=new EncapsulatedClass();
            obj.name="Abhinn";
            obj.profile="Junior Software Developer";
            Console.WriteLine(obj.name+" "+obj.profile);
        }
    }
}
