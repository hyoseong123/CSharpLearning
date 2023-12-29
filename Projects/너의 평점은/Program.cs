using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            double totalPoint = 0;
            double total = 0;

            for (int i = 0; i < 20; i++)
            {
                string str = Console.ReadLine();

                string[] list = str.Split(" ");

                string subject = list[0];
                double point = double.Parse(list[1]);
                string grade = list[2];

                switch (grade)
                {
                    case "A+":
                        total += point * 4.5;
                        totalPoint += point;
                        break;
                    case "A0":
                        total += point * 4.0;
                        totalPoint += point;
                        break;
                    case "B+":
                        total += point * 3.5;
                        totalPoint += point;
                        break;
                    case "B0":
                        total += point * 3.0;
                        totalPoint += point;
                        break;
                    case "C+":
                        total += point * 2.5;
                        totalPoint += point;
                        break;
                    case "C0":
                        total += point * 2.0;
                        totalPoint += point;
                        break;
                    case "D+":
                        total += point * 1.5;
                        totalPoint += point;
                        break;
                    case "D0":
                        total += point * 1.0;
                        totalPoint += point;
                        break;
                    case "F":
                        total += point * 0;
                        totalPoint += point;
                        break;
                    default:
                        break;
                }
            }

            Console.WriteLine(Math.Round(total / totalPoint, 6));
        }
    }
}
