using System;

namespace Diamond_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string scaleNumber = Console.ReadLine();

            // 입력받은 수 int 형으로 변환
            int scale = int.Parse(scaleNumber);
            int n = 0;

            for (int i = 0; i < scale * 2; i += 2)
            {
                for (int j = scale - 1; j > i/2; j--)
                {
                    Console.Write(" ");
                }

                for (n = 0; n <= i; n++)
                {
                    Console.Write("*"); 
                }

                Console.WriteLine();
            }   

            n = n - 2;

            for (int i = n; i > 0; i -= 2)
            {
                for (int j = scale - 1; j > i / 2; j--)
                {
                    Console.Write(" ");
                }

                for (int j = 0; j < i; j++)
                {
                   Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
