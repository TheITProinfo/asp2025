namespace ConsoleApp1day4demo7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("please enter your password:");
            string myPassword = Console.ReadLine();

            while (myPassword!="Secret123")
            {

                Console.WriteLine("enter password");
                myPassword = Console.ReadLine();

            }

            Console.WriteLine("access granted!!");
        }
    }
}
