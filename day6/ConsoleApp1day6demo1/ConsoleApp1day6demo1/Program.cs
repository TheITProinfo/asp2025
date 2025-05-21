namespace ConsoleApp1day6demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is a example inserting sort

            int[] arr = { 15,24,4,2,100,-50};

            Console.WriteLine("the original array is ");
            printArray(arr);

            // inseting sort

            for (int i = 1; i < arr.Length; i++)   // get next cards
            {
                int insertval = arr[i]; // define to be insert value 
                int insertIndex = i - 1;

                while (insertIndex>=0 && (insertval < arr[insertIndex])) 


                {
                    arr[insertIndex + 1] = arr[insertIndex];
                    insertIndex--;


                
                } //end of while loop

                // when exit the while loop, the insert values'index is found


                arr[insertIndex + 1] = insertval;
                   

            } // end of for loop


            Console.WriteLine("the inserting sort is ");

            printArray(arr);



        } // end of main 

        // this function to print all item in the array

        static void printArray(int[] array) {

            foreach (int item in array)
            {

                Console.Write("{0}\t",item);
            }
        
        
        }
    }
}
