using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day7demo1
{
    internal class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        // auto-implemented property
        private int _age;

        public int Age
        {
            get { return _age; }

            set
            {
                if(value>=0)
                    _age = value;
                else
                
                    Console.WriteLine("Age cannot be negative");
                
            }
        }

        // read-only property
        public string FullName
        {
            get { return FirstName + "cstCollege"; }
        }

       


    }
}
