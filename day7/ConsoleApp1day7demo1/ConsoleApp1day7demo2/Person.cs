﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day7demo2
{
    internal class Person
    {
        // auto implemented property
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }    

        // constructor method

        public Person(int id,string firstName,string lastName,int age)
        {
            Id = id;
            FirstName = firstName;
            LastName = lastName;
            Age = age;

        }

        public void Speak()
        {
            Console.WriteLine("I am speaking");
        }

    }
}
