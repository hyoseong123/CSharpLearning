using System;

namespace Bridge_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("서쪽과 동쪽의 사이트를 순서대로 입력해주세요 : ");

            string westAndEastTemp = Console.ReadLine();
            string[] westAndEastArrTemp = westAndEastTemp.Split(' ');

            int westNumber = int.Parse(westAndEastArrTemp[0]);
            int eastNumber = int.Parse(westAndEastArrTemp[1]);
            
            long[,] birdgeArr = new long[30, 30];

            birdgeArr[0, 0] = 1;
            birdgeArr[1, 1] = 1;
            birdgeArr[1, 0] = 2;

            // bridgeArr는 1번까지 미리 선언해놨기에 2번부터 배열.
            for (int i = 2; i < birdgeArr.GetLength(0); i++)
            {
                for (int j = 2; j < birdgeArr.GetLength(1); j++)
                {
                    birdgeArr[i, j - 1] = birdgeArr[i - 1, j - 2] + birdgeArr[i - 1, j - 1];

                    birdgeArr[i, 0] = i + 1;
                }
            }
            
            Console.WriteLine(birdgeArr[eastNumber - 1, westNumber - 1]);
        }
    }
}
