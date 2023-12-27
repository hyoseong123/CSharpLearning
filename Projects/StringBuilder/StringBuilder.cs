using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            // StringBuilder 선언.
            StringBuilder stringBuilder = new();

            int t = int.Parse(Console.ReadLine());

            int[] a = new int[t];
            int[] b = new int[t];

            for (int i = 0; i < t; i++)
            {
                string[] s = Console.ReadLine().Split(" ");

                a[i] = int.Parse(s[0]);
                b[i] = int.Parse(s[1]);

                // 숫자를 더한 뒤 문자로 변환해 스트링빌더에 저장.
                stringBuilder.AppendLine((a[i] + b[i]).ToString());
            }

            Console.WriteLine(stringBuilder.ToString());
        }
    }
}
