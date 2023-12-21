using System;

namespace Factorial_HHS
{
    class Program
    {
        static int result;

        static void Main(string[] args)
        {
            Console.Write("팩토리얼을 알고 싶은 정수를 입력해주세요 (1 ~ 10) : ");
            
            string factorialNumberTemp = Console.ReadLine();

            int factorialNumber = int.Parse(factorialNumberTemp);

            result = 1;

            Factorial(factorialNumber);

            Console.WriteLine(result);
        }

        private static void Factorial(int factorialNumber)
        {
            if (factorialNumber == 1)
            {
                return;
            }

            result *= factorialNumber;
            
            Factorial(factorialNumber - 1);
        }

    }
}
