namespace ConsoleApp1day9demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Teacher teach1 = new Teacher();
            Student stu1 = new Student();

            teach1.Age = 25;
            teach1.Gender = "Male";
            teach1.Speak();

            stu1.Age = 20;
            stu1.Gender = "Male";
            stu1.Speak();


        }
    }
}
