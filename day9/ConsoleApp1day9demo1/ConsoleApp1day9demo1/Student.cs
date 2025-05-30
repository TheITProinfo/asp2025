using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day9demo1
{
   public class Student:Person
    {
        public int StuId { get; set; }

        // // over write parent method
        public override void Speak()
        {
            Console.WriteLine("I am student, nice to meet you!");
        }
    }
}
