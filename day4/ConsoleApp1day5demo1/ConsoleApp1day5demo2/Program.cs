namespace ConsoleApp1day5demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //this is a example insert sorting

            int[] numbers = {18, 56, 7, 10, 66 };
            Console.WriteLine("the original arry");
            PrintArray(numbers);

            // insert sorting

            int n = numbers.Length;
            Console.WriteLine("the lenght of the array{0}",n);

            for (int i = 1; i < n; i++) //outer loop 
            {

                int temp = numbers[i];   // pick up next card to insert
                int j = i - 1;
                while (j >= 0 && numbers[j] > temp)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                  
                }

                numbers[j + 1] = temp;  // insert the next card into its correct position

            }

            Console.WriteLine("the sorting result");
            PrintArray(numbers);













            //
            // this function print array
            // parameter --array
            //


            static void PrintArray(int[] array)
            {

                foreach (int item in array)
                {
                    Console.Write("{0}\t", item);
                }

                Console.WriteLine("");
            }




        } // main function
    }
}
