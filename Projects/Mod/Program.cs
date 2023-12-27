using System;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[10];
            int[] mods = new int[10];

            int result = 0;

            int count = 0;

            for (int i = 0; i < 10; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());

                // 42로 나누기
                mods[i] = numbers[i] % 42;
            }

            while (count < 10)
            {
                bool isSame = false;

                for (int i = 0; i < count; i++)
                {
                    if (mods[count] == mods[i])
                    {
                        isSame = true;
                        break;
                    }
                }

                // 같은 숫자가 나오지 않으면 1 추가
                if (!isSame)
                {
                    result++;
                }

                count++;
            }

            Console.WriteLine(result);
        }
    }
}
