namespace ConsoleApp1day4demo8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // this is example 

            int iRow, iColumn;
            for ( iRow = 1; iRow <10; iRow++)  // define how many rows 
            {
                // for (iColumn = 1; iColumn <= 10; iColumn++)
                for (iColumn = 1; iColumn <= iRow; iColumn++)
                {
                    Console.Write("{0}*{1}={2}\t",iRow,iColumn,iRow*iColumn);


                }

                Console.WriteLine(); // new line

            }

        }
    }
}
