using System;

namespace Random_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int randomFisrtNumber = random.Next(1,10);
            int randomSecondNumber = random.Next(100, 123);
            int randomThirdNumber = random.Next(54, 66);

            Console.WriteLine(randomFisrtNumber);
            Console.WriteLine(randomSecondNumber);
            Console.WriteLine(randomThirdNumber);
        }
    }
}
