using System;

namespace NumberBaseball_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("GM : 숫자 야구를 시작합니다. 숫자를 입력해주세요.");

            Random random = new Random();
            int[] key = new int[3];

            key[0] = random.Next(1, 9);
            key[1] = random.Next(1, 9);
            key[2] = random.Next(1, 9);

            if (key[0] == key[1] || key[1] == key[2] || key[0] == key[2])
            {
                key[0] = random.Next(1, 9);
                key[1] = random.Next(1, 9);
                key[2] = random.Next(1, 9);
            }
            
            while(true) 
            {
                int strike = 0;
                int ball = 0;

                Console.Write("Player : "); 

                string numberTmp = Console.ReadLine();

                if (!int.TryParse(numberTmp, out int isNumber))
                {
                    Console.WriteLine("숫자를 입력해주세요.");
                    continue;
                }

                int number = int.Parse(numberTmp);
                int[] numberArr = new int[3];

                numberArr[0] = number / 100;
                numberArr[1] = (number % 100) / 10;
                numberArr[2] = (number % 10);

                if (number > 999 || number < 100)
                {
                    Console.WriteLine("3자리 숫자를 입력해주세요.");
                    continue;
                }
                
                if (numberArr[0] == numberArr[1] || numberArr[1] == numberArr[2] || numberArr[0] == numberArr[2])
                {
                    Console.WriteLine("서로 다른 숫자를 입력해주세요.");
                    continue;
                }

                if (numberArr[0] >= 10 || numberArr[0] < 1 || numberArr[1] >= 10 || numberArr[1] < 1 || numberArr[2] >= 10 || numberArr[2] < 1)
                {
                    Console.WriteLine("1 ~ 9 사이의 숫자를 입력해주세요.");
                    continue;
                }

                for (int i = 0; i < key.Length; i++)
                {
                    for (int j = 0; j < numberArr.Length; j++)
                    {
                        if (key[i] == numberArr[j])
                        {
                            if (i == j)
                            {
                                strike++;
                                continue;
                            }

                            ball++;
                            continue;
                        }

                        continue;
                    }
                }

                if (strike == 3)
                {
                    Console.WriteLine("당신이 승리하였습니다. ");
                    return;
                }

                Console.WriteLine($"{strike} Strike, {ball} Ball 입니다.");
            }
        }
    }
}
