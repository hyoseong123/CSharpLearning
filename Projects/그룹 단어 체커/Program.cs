using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            int cnt = int.Parse(Console.ReadLine());

            int res = 0;

            while (cnt != 0)
            {
                string st = Console.ReadLine();

                string[] list = new string[st.Length];

                bool bl = false;

                for (int i = 0; i < st.Length; i++)
                {
                    for (int j = i; j < st.Length; j++)
                    {
                        // i번째에서 2칸 뒤에 있는 알파벳 탐색
                        if (j - i > 1)
                        {
                            if (st.Substring(i, 1) == st.Substring(j, 1))
                            {
                                bl = true;
                            }
                        }

                        // i번째에서 바로 뒤에 같은 알파벳이 있으면 i++
                        if (st.Substring(i, 1) == st.Substring(j, 1))
                        {
                            i += j - i;
                        }
                    }
                }

                if (!bl)
                {
                    res++;
                }

                cnt--;
            }

            Console.WriteLine(res);
        }
    }
}
