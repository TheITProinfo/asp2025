namespace ConsoleApp1day7demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Person p1 = new Person();

            // using set
            p1.FirstName = "Tom";
            p1.Age = 35;
            p1.Id = 10001;

            Console.WriteLine("the Firstname:{0}", p1.FirstName);
            Console.WriteLine("his full name is {0}",p1.FullName);
            Console.WriteLine("Tom is {0} years old",p1.Age);
            p1.Age = -5;


            Person p2 = new Person();
            p2.Age = 45;
            p2.FirstName = "Jory";
            p2.Id = 10002;


            Person p3 = new Person();
            p3.Age = 30;
            p3.FirstName = "Alice";
            p3.Id = 10003;




        } //end of main 
    }
}
