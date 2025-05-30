using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day8demo1
{   

    // derived from parent class Person
    public class Employee:Person
    {
        public int EmployeeId { get; set; }
        public string CompanyName { get; set; }

        public void Learn()
        {
            Console.WriteLine("I am learning, my height {0} ",this.Height);
        }

        public int GetWeight()
        {
            return this.Weight;

        }

    }
}
