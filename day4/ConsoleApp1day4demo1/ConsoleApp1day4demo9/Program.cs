namespace ConsoleApp1day4demo9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] fruits = new fruits[4];

            string[] fruits = { "orange", "banana","apple","peal"};

            Console.WriteLine("acces the eletment No.2 {0}", fruits[1]);
            fruits[1] = "blue berry";
            Console.WriteLine(" after modify the eletment No.2 {0}", fruits[1]);

            // access each elements

            foreach (string myFruit in fruits)
            {
                Console.WriteLine("---------my fruits-----------");
                Console.WriteLine("each my fruit is {0}",myFruit);
            }
        }
    }
}
