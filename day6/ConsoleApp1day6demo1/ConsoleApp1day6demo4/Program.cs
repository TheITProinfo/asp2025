namespace ConsoleApp1day6demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // create a object from the class Person

           Person p1 = new Person();

            p1._name = "Tom";  // assign the value
            p1._age = 25;
            p1._gender = "male";
            p1.Speak();  // call method
            p1.Drive();

            Person p2 = new Person();
            p2._name = "Jerry";
            p2._age = 35;
            p2._gender = "male";
            p2.Speak();
            p2.Drive();


            Car myCar = new Car();

            myCar._color = "Red";
            myCar._speed = 100;

            myCar.Drive();




           
            

        }


    } // end of calss

    

} // end of namespace
