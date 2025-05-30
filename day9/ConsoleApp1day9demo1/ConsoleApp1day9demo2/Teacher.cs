using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day9demo2
{
    internal class Teacher:Person
    {
        public int TechId { get; set; }

        // shortcut alt+shift+f10

        public override void Speak()
        {
            //
            Console.WriteLine("I am a teacher, nice to meet you!");
        }
    }
}
