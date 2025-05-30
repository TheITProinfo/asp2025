using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day9demo2
{
  public class Student:Person
    {
        public int StuId { get; set; }

        public override void Speak()
        {
            Console.WriteLine("I am a student, nice to mee you!");
        }
    }
}
