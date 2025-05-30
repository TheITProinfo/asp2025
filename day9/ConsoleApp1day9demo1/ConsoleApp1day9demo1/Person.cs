using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day9demo1
{
    public class Person
    {
        public string Gender { get; set; }
        public int Age { get; set; }

        // add virtual keyword
        public virtual void Speak()
        {
            Console.WriteLine("I am a student, nice to meet you!");
        }
    }
}
