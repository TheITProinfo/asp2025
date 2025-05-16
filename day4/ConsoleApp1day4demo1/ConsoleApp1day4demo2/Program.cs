using System.Text;

namespace ConsoleApp1day4demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string str = "";

            long startTime = DateTime.Now.Millisecond;

            for (int i = 0; i < 10000; i++)
            {
                str = str + i;

            }

            long endTime = DateTime.Now.Millisecond;

            long runTime = endTime - startTime;

            Console.WriteLine("the string  is running  {0}",runTime);


            StringBuilder sb1 = new StringBuilder(" ");
            long startTime1 = DateTime.Now.Millisecond;

            for (int i = 0; i < 10000; i++)
            {
                sb1.Append(i);

            }

            long endTime1 = DateTime.Now.Millisecond;

            long runTime1= endTime1 - startTime1;

            Console.WriteLine("the string builder is running {0}",runTime1);
        }
    }
}
