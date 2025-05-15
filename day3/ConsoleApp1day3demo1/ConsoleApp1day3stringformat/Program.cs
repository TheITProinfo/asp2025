namespace ConsoleApp1day3stringformat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // define datetime variable day1

            DateTime day1 = DateTime.Now;
            string myStr=String.Format("{0:D}", day1);
            Console.WriteLine("mystr is {0}",myStr);
            Console.ReadKey();
        }
    }
}
