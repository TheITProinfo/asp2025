using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day9demo1
{
    public class Teacher:Person
    {
        public int TeachId { get; set; }
        // over write parent method
       
        public override void Speak()
        {
            Console.WriteLine("I am Teacher, nice to meet you!!");
        }
    }
}
