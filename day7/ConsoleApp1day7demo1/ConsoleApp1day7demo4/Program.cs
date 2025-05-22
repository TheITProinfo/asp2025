namespace ConsoleApp1day7demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // access the static member by class name.member
            Car.TotalCarsProduced = 10000;
            

            Car car1 = new Car("TSL", "model3");

            // call class method
            car1.Run();
            Console.WriteLine("total produced:{0}", Car.TotalCarsProduced);
            // call static method

            



        }
    }
}
