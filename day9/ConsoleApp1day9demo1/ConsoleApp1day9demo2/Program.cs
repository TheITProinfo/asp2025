namespace ConsoleApp1day9demo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Teacher teach1 = new Teacher();
            teach1.Age = 35;
            teach1.Gender = "Female";
            teach1.Speak();

            Student stu1 = new Student();
            stu1.Age = 12;
            stu1.Gender = "Male";
            stu1.StuId = 200;
            stu1.Speak();

        }
    }
}
