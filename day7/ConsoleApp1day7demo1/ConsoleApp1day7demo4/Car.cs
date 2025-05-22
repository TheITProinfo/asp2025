using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1day7demo4
{
    public class Car
    {
        // static field, shared by all Car instance
        public static int TotalCarsProduced;

        // prop+tab
        public string Maker { get; set; }
        public string Model { get; set; }

        // constructor method

        public Car(string maker,string model)
        {
            this.Maker=maker;
            this.Model=model;

            


        }

        public void Run()
        {
            Console.WriteLine("this is {0}, model: {1}", this.Maker, this.Model);
        }



    }
}
