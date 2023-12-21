using System;

namespace Rectangle_HHS
{
    class Program
    {
        static void Main(string[] args)
        {
            string scaleStringTemp = Console.ReadLine();

            string[] scaleArrTemp = scaleStringTemp.Split(" ");

            int height, width;
            height = int.Parse(scaleArrTemp[0]);
            width = int.Parse(scaleArrTemp[1]);

            Console.WriteLine($"사각형의 넓이는 : {height * width} 입니다.");
        }
    }
}

