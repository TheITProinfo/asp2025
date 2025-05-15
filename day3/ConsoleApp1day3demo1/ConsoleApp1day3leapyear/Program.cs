using System.Threading.Channels;

namespace ConsoleApp1day3leapyear
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a example to check which year is a leap year

            Console.WriteLine("please input the year");
            string strYear = Console.ReadLine(); // get the year from the keyboard
            int year = Int32.Parse(strYear); // conver the year to int

            bool isleapYear = ((year % 400) == 0) || (((year % 4 == 0) && ((year % 100) != 0)));

            string yesorno = isleapYear ? "yes" : "no";

            Console.WriteLine("the year you input {0} is leapyear {1}", strYear, yesorno);

            Console.ReadKey();

        }
    }
}
