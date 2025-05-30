using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day8demo2
{
   public class Employee:Person
    {

        // child class constructor method
        public Employee():base("this is  example of derived from parent class")
        {
            Console.WriteLine("Employee 's constructor");
        }
    }
}
