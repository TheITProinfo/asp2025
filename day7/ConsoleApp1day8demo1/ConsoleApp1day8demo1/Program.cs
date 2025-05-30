namespace ConsoleApp1day8demo1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // delete one line short cut ---ctrl+shift+L

            Employee emp1 = new Employee();
            //Employee emp2 = new Employee();

            // derived from paren class --public members
            emp1.FirstName = "Alice";
            emp1.LastName = "Wang";
            emp1.Age = 25;
            emp1.Gender = "Female";

            
            // not access to private members of the parent class
            // emp1.BankAccount=


            
            
            
            // child class property

            emp1.EmployeeId = 100;
            emp1.CompanyName = "Oracle";

            emp1.Height = 185;

            // call parent method
            var fullName = emp1.GetFullName();



            Console.WriteLine("the apps is running properly");

            Console.WriteLine("id is {0},full name {1},company name is{2} ",emp1.EmployeeId,fullName,emp1.CompanyName);






        }
    }
}
