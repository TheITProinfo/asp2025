using System.Runtime.InteropServices.Marshalling;

namespace ConsoleApp1day7demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person(100, "Alice","Wang", 25);
            p1.Speak();
            Console.WriteLine("person p1 is created!!");


            Person p2 = new Person(101, "Bob", "Zhang", 20);
            p2.Speak();
            Console.WriteLine("person p2 has been created!");
        }
    }
}
