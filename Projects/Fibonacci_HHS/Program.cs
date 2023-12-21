using System;

namespace Fibonacci_HHS
{
    class Program
    {
        static int result;

        static void Main(string[] args)
        {
            Console.Write("피보나치 수열에서 더하고 싶은 항을 입력해주세요 : ");

            string fibonacciNumberTemp = Console.ReadLine();
            string[] fibonacciNumberTempArr = fibonacciNumberTemp.Split(' ');

            int fibonacciFirstNumber = int.Parse(fibonacciNumberTempArr[0]);
            int fibonacciSecondNumber = int.Parse(fibonacciNumberTempArr[1]);

            int[] fibonacciArr = new int[30];

            fibonacciArr[0] = 0;
            fibonacciArr[1] = 1;

            // 피보나치 전체 배열 선언
            for (int i = 2; i < 30; i++)
            {
                fibonacciArr[i] = fibonacciArr[i - 1] + fibonacciArr[i - 2];
            }

            Fibonacci(fibonacciFirstNumber, fibonacciSecondNumber, fibonacciArr);

            Console.WriteLine(result);
        }

        private static void Fibonacci(int firstNumber, int secondNumber, int[] arr)
        {
            if (firstNumber == secondNumber + 1)
            {
                return;
            }

            foreach (var item in arr)
            {
                if (item == arr[firstNumber])
                {
                    result += item;
                    break;
                }
            }

            firstNumber++;

            Fibonacci(firstNumber, secondNumber, arr);
        }
    }
}
