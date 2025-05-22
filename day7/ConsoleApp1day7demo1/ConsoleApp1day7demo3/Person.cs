using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day7demo3
{
    internal class Person
    // [access modifier---public/internal/private/protected] [return type] [class name]
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        // constructor method
        public Person(int id,string firstName,string lastName,int age)
        {
            // this refer to the instance of the class
            this.Id = id;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;


        }

        public void Speak()
        {

            Console.WriteLine(" my firstname is {0}, lastname{1},My ID is {2}, I am {3} yesrs old ",this.FirstName,this.LastName,this.Id,this.Age);

        }

    }
}
