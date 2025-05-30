using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day8demo3
{
    public class Dog:IAnimal
    {
        public void Speak()
        {
            Console.WriteLine(" I am barking!");
        }

        public void Move()
        {
            Console.WriteLine("Dog is running");
        }
    }
}
