namespace ConsoleApp1day7demo5
{
    internal class Program
    {
        static void Main(string[] args)
        {

         // call static method under static class

         Console.WriteLine("the square of the circle is :{0}",Utility.Square(10));

         Console.WriteLine("the square of the rectangle is {0}",Utility.RecSquare(11.2,22.2));
         
        }
    }
}
