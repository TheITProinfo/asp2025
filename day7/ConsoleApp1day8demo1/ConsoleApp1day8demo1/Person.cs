using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day8demo1
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        // can not be accessed from child class, 
        private string BankAccount { get; set; }

        // protected members
        protected int Weight { get; set; }

        // internal 

        internal int Height { get; set; }


        //// constructor method
        //Person(string firstName,string lastName,string gender,int age)
        //{
        //    this.Age=age;
        //    this.FirstName=firstName;
        //    this.LastName=lastName;
        //    this.Gender=gender;

        //}

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

        public string GetFullName()
        {

            return this.FirstName+" "+this.LastName;
        }


        
    }
}
