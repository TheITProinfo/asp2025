namespace ConsoleApp1day3demo1
{
    internal class Program
    {
        enum myDate
        { 
          Sunday,
          Monday,
          Tuesday,
          Wednesday,
          Thursday,
          Friday,
          Saturday

        
        
        }
        
        
        static void Main(string[] args)
        {
            // this is a example of data enum type

            int k = (int)DateTime.Now.DayOfWeek;
            k = 5;

            Console.WriteLine("the value of K is {0}",k);
            switch(k)
                {
                case (int)myDate.Sunday:
                    Console.WriteLine("today is Sunday");break;
                case (int)myDate.Monday:
                    Console.WriteLine("today is Monday");break;
                case (int)myDate.Wednesday:
                    Console.WriteLine("today is Wenesday"); break;
                case (int)myDate.Thursday:
                    Console.WriteLine("today is Thursday"); break;
                case (int)myDate.Friday:
                    Console.WriteLine("today is Friday"); break;
                case (int)myDate.Saturday:
                    Console.WriteLine("today is Saturday"); break;


            }



        }
    }
}
