using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharpHandOnPractice.ClassAndObjects
{   
class ParametrizedConstrucotr
    {
        public ParametrizedConstrucotr(string name)
        {
            this.name=name;
        }
        string name;
        public static void Main(string[] args)
        {
            var obj=new ParametrizedConstrucotr("abhinn");
            Console.WriteLine(obj.name);
            
        }
    }
}