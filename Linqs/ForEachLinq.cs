using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace CSharpHandOnPractice.Linqs
{   public class User
    {
        public string Name { get; set; }
        public bool Active { get; set; }
    }
    public static partial class Example
    {

        public static void GetUsers(List<User> users)
        {
            var userQuery = from user in users
            group user by user.Active into userGroup
            select userGroup;
            foreach(var userGroup in userQuery)
            {
                Console.WriteLine("Active: {0}",userGroup.Key);
            }
            
        }

    }
}