using System;
using System.Collections.Generic;
using System.Text;

namespace baekjoon
{
    class Program
    {
        static void Main(string[] args)
        {
            string st = Console.ReadLine();

            st += "  ";

            int count = 0;

            for (int i = 0; i < st.Length - 2; i++)
            {
                if (st.Substring(i, 2) == "c=")
                {
                    count++;
                    i++;
                }
                else if(st.Substring(i, 2) == "c-")
                {
                    count++;
                    i++;
                }
                else if (st.Substring(i, 2) == "d-")
                {
                    count++;
                    i++;
                }
                else if (st.Substring(i, 3) == "dz=")
                {
                    count++;
                    i += 2;
                }
                else if (st.Substring(i, 2) == "lj")
                {
                    count++;
                    i++;
                }
                else if (st.Substring(i, 2) == "nj")
                {
                    count++;
                    i++;
                }
                else if (st.Substring(i, 2) == "s=")
                {
                    count++;
                    i++;
                }
                else if (st.Substring(i, 2) == "z=")
                {
                    count++;
                    i++;
                }
                else if(st.Substring(i, 1) != " ")
                {
                    count++;
                }
            }

            Console.WriteLine(count);
        }
    }
}
