namespace ConsoleApp1day4demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Please input an option: ");
            string mySelecion=Console.ReadLine();

            // int options = 2;

            int options = Int32.Parse(mySelecion);

            switch (options)
            {

                case 1:
                    Console.WriteLine("Start the Game"); break;
                case 2:
                    Console.WriteLine("load gane");break;
                case 3:
                    Console.WriteLine("exit game");break;
                default:
                    Console.WriteLine("invalid selection");break;



            } // end of switch




        } // end of main function
    }
}
