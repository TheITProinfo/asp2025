using System.Text.RegularExpressions;
namespace ConsoleApp1day4demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string text = "my phone number is 123-456-7890";
            Regex regex = new Regex(@"\d{3}-\d{3}-\d{4}");

            Match match = regex.Match(text);
            if (match.Success)
            {
                Console.WriteLine("found the cell number!!"+ match.Value);

            }

        }
    }
}
