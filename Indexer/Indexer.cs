using System;
namespace CSharpHandsOnPractice.Indexer
{
    public class Employee
    {
        int Eno;
        string Ename;
        string Job;
        int Salary;
        string Dname;
        string Location;
        public Employee(int Eno,string Ename,string Job,int Salary,string Dname,string Location)
        {
            this.Eno = Eno;
            this.Ename = Ename;
            this.Job = Job;
            this.Salary = Salary;
            this.Dname = Dname;
            this.Location = Location;
            
        }
        public object this[int index]
        {
            get
            {
                if (index == 0)
                    return Eno;
                else if (index == 1)
                    return Ename;
                else if (index == 2)
                    return Job;
                else if (index == 3)
                    return Salary;
                else if (index == 4)
                    return Dname;
                else if (index == 5)
                    return Location;
                return null;
                
            }



        }



    }
    public class Indexer
    {
        static void Main(string[] args)
        {
            var emp = new Employee(123,"Rohan","Software Engineer",3000,"Mohan","Delhi");
            Console.WriteLine("Eno= "+emp[0]);
            Console.WriteLine("Ename= "+ emp[1]);
            Console.WriteLine("Job ="+ emp[2]);
            Console.WriteLine("Salary= "+ emp[3]);
            Console.WriteLine("Dname= "+ emp[4]);
            Console.WriteLine("Location= " + emp[5]);

        }
    }
}