using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day6demo4
{
     class Person
    {
      //define field of the person
        public string _name;
        public int _age;
        public string _gender;

        //define method of the person

        public void Speak()
        {
            Console.WriteLine("I can talk");
        }

        public void Drive()
        {
            Console.WriteLine("--------Driving------");
            Console.WriteLine("I am driving");
        }

    }
}
