namespace ConsoleApp1day5demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a example of bubble algorithm

            int[] numbers = { 55, 29, 14, 10, 36 };
            Console.WriteLine("the original array");

            
            PrintArray(numbers);

            // bubble sorting

            for (int i = 0; i < numbers.Length-1; i++) // outer loop
            {


                for (int j = 0; j <numbers.Length-1 ; j++)  // inner loop : compare 2 items
                {


                    if (numbers[j] > numbers[j + 1])
                    {
                        // swap the 2 numbers
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                     }

                } // inner loop 

            } // outer loop
            Console.WriteLine("");

            Console.WriteLine("the bubble sorting result");

            
            PrintArray(numbers);
       
        //
        // this function print array
        // parameter --array
        //


        static void PrintArray(int[] array)
            {

                foreach (int item in array)
                {
                    Console.Write("{0}\t",item);
                }

            
            }
          
        
        
        
        
        
        
        
        } // main function
    }
}
