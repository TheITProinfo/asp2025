namespace ConsoleApp1day4demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //define datetime variable name now
            DateTime now = DateTime.Now;

            Console.WriteLine("now is {0}",now);
            Console.WriteLine("now is {0:D}", now);
            Console.WriteLine("now is {0:d}", now);

        }
    }
}
