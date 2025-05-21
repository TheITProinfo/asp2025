using System.Collections;

namespace ConsoleApp1day6demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a example of arraylist

            ArrayList list = new ArrayList(); // define a ist

            for (int i = 0; i < 20; i++)
            {

                list.Add(i);

            }

            foreach (int item in list)
            {

                Console.WriteLine("the each item is {0}",item);
            }

        }
    }
}
