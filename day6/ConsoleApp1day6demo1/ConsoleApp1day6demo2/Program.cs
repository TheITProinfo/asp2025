namespace ConsoleApp1day6demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int[] arr = { 12, 35, 40, 22, 11, 100 };

            Console.WriteLine("the original array is ");
            printArray(arr);

            // selection sorting
            int n = arr.Length;

            for (int i = 0; i < n; i++) // outer loop
            {

                int min = i;

                for (int j = i+1; j < n; j++)
                {

                    if (arr[j] < arr[min])
                    {
                        min = j; 
                    }



                } // end of inner for loop 

                int temp = arr[min];
                arr[min] = arr[i];
                arr[i] = temp;






            } // end of outer loop 





            Console.WriteLine();
            Console.WriteLine("selection sorting is ");
            printArray(arr);








        } // end of main function






        // this function to print all item in the array

        static void printArray(int[] array)
        {

            foreach (int item in array)
            {

                Console.Write("{0}\t", item);
            }
        } // end of printarrya function
   
    
    
    
    
    
    
    
    
    } // end of class

}

