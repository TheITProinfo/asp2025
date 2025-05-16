using System.Text.RegularExpressions;

namespace ConsoleApp1day4demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string emailTxt = "abcd@hotmail.com";
            // create new object emailRegex
            Regex emailRegex = new Regex(@"^\w+@\w+\.\w+$");

            Match match = emailRegex.Match(emailTxt);

            if (match.Success)
            {
                Console.WriteLine("found the email:" + match.Value);
            }

            else
            {
                Console.WriteLine("not found!!");
            }
        }
    }
}
