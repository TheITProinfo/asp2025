using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day9demo2
{
    public abstract class Person
    {
        public string Gender { get; set; }
        public int  Age { get; set; }

       // define a abstract method
        public abstract void Speak();
    }
}
