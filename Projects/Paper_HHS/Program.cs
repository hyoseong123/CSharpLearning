using System;

namespace Paper_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] table = new int[100, 100];

            Console.Write("색종이의 개수를 입력해주세요 : ");

            string paperNumberTemp = Console.ReadLine();

            int paperNumber = int.Parse(paperNumberTemp);

            int whileCount = 0;

            while (whileCount != paperNumber)
            {
                Console.Write("색종이의 좌상단 좌표를 입력해주세요 : ");

                string paperPointTemp = Console.ReadLine();
                string[] paperPointArr = paperPointTemp.Split(" ");

                int pointX = int.Parse(paperPointArr[0]);
                int pointY = int.Parse(paperPointArr[1]);

                for (int i = pointX; i < pointX + 10; i++)
                {
                    for (int j = pointY; j < pointY + 10; j++)
                    {
                        table[i, j] = 1;
                    }
                }

                whileCount++;
            }

            int oneCount = 0;

            for (int i = 0; i < table.GetLength(0); i++)
            {
                for (int j = 0; j < table.GetLength(1); j++)
                {
                    if (table[i, j] == 1)
                    {
                        oneCount++;
                    }
                }
            }

            Console.WriteLine($"총 넓이는 {oneCount}입니다.");
        }
    }
}
