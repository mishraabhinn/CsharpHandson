using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharpHandOnPractice.ClassAndObjects
{   
class CopyConstructor
    {
        public CopyConstructor(string name)
        {
            this.name=name;
        }
        public CopyConstructor(CopyConstructor obj)
        {
            this.name=obj.name;
        }
        string name;
        public static void Main(string[] args)
        {
            var obj=new CopyConstructor("abhinn");
            var obj1=new CopyConstructor(obj);
            Console.WriteLine(obj.name);
            Console.WriteLine(obj1.name);
            
        }
    }
}