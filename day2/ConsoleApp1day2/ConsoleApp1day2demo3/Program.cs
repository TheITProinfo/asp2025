namespace ConsoleApp1day2demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            int num1 = 2025;
            int num2 = num1;
            num2 = 5000;

            Student student1 = new Student(); // create  student1 object

            Student student2 = new Student();

            student2 = student1;

            student2.height = 190;

            Console.WriteLine("the values of num1 and num2 {0},{1} ",num1,num2);
            Console.WriteLine( "the  value of height {0},{1}",student1.height,student2.height);

            Console.ReadKey();

        }


        /*
         * define a simple student class
         */
        class Student
        {
            public int height = 185;
        }
    
    }
}
