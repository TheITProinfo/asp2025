namespace ConsoleApp1day8demo4
{
    internal class Program
    {
        static void Main(string[] args)
        {
           // this is a example for virtual method

           Animal animal1 = new Animal();

           Pig pig1 = new Pig();
          Dog dog1 = new Dog();

           animal1.AnimalSound();
           pig1.AnimalSound();
           dog1.AnimalSound();

        }
    }
}
