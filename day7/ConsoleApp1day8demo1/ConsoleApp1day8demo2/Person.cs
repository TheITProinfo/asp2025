using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day8demo2
{
    public class Person
    {
        
        // constructor method
        public Person()
        {
            Console.WriteLine("parent class Person constructor");
        }

        public Person(string val)
        {
            Console.WriteLine(val);
        }
    }
}
