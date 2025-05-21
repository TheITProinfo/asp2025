namespace ConsoleApp1day6classDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.Age = 45;
            p1.Gender = "female";

            p1.Speak();
            Console.WriteLine("I am {0} years old, gender\t{1}",p1.Age,p1.Gender);

        }
    }
}
