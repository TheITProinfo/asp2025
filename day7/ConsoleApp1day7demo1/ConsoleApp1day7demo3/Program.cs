namespace ConsoleApp1day7demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // Console.WriteLine("Hello, World!");

           Person p1 = new Person(100, "Alice", "Zhang", 25);
           p1.Speak();


           Person p2 = new Person(101, "Bob", "Chang", 26);
           p2.Speak();
        }
    }
}
