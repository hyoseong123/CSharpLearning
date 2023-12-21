using System;
using System.Collections.Generic;

namespace SpinCircle_HHS
{
    class Program
    {
        static public int xi;
        static public int di;
        static public int ki;

        static public int n;
        static public int m;
        static public int t;

        static void Main(string[] args)
        {
            string nmtTmp = Console.ReadLine();

            string[] nmtTmpArr = nmtTmp.Split(" ");

            n = int.Parse(nmtTmpArr[0]);
            m = int.Parse(nmtTmpArr[1]);
            t = int.Parse(nmtTmpArr[2]);

            List<Queue<int>> queList = new List<Queue<int>>();

            // 전체 배열 queList 에 저장.
            for (int i = 0; i < n; i++)
            {
                string quetmp = Console.ReadLine();

                string[] queListTmp = quetmp.Split(" ");

                queList.Add(new Queue<int>());

                for (int j = 0; j < m; j++)
                {
                    queList[i].Enqueue(int.Parse(queListTmp[j]));
                }
            }

            // 규칙 회전 입력.
            for (int i = 0; i < t; i++)
            {
                string spinTimeTmp = Console.ReadLine();
                string[] spinTime = spinTimeTmp.Split(" ");

                xi = int.Parse(spinTime[0]);
                di = int.Parse(spinTime[1]);
                ki = int.Parse(spinTime[2]);

                for (int j = xi; j <= queList.Count; j += j)
                {
                    SpinCircle(queList[j - 1]);
                }
            }

            int[,] arr = new int[n, m];
            int res = 0;

            // queList를 2차원 배열로 변환
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = queList[i].Dequeue();
                }
            }
            
            List<int> zeroNumTemp = new();

            // 겹치는 숫자의 주소를 zeroNumTemp에 저장.
            MakeZeroNumTemp(zeroNumTemp,arr);

            int zeroNumCount = 0;

            // zeroNumTemp를 이용해 0으로 변환.
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (zeroNumTemp.Count == 0)
                    {
                        res += arr[i, j];
                        
                        continue;
                    }

                    if (i == zeroNumTemp[zeroNumCount] && j == zeroNumTemp[zeroNumCount + 1])
                    {
                        arr[i, j] = 0;

                        zeroNumTemp.RemoveAt(zeroNumCount);
                        zeroNumTemp.RemoveAt(zeroNumCount);
                    }

                    res += arr[i, j];
                }
            }

            // 결과출력.
            Console.WriteLine(res);
        }
    
        static void SpinCircle(Queue<int> que)
        {
            if (di == 1)
            {
                for (int i = 0; i < ki; i++)
                {
                    que.Enqueue(que.Dequeue());
                }
            }
            // 0이면 시계방향.
            else if(di == 0)
            {
                ReverseQue(que);

                for (int i = 0; i < ki; i++)
                {
                    que.Enqueue(que.Dequeue());
                }

                ReverseQue(que);
            }
        }

        static Queue<int> ReverseQue(Queue<int> que)
        {
            Stack<int> stk = new();

            int count = que.Count;
            
            for (int i = 0; i < count; i++)
            {
                stk.Push(que.Dequeue());
            }

            for (int i = 0; i < count; i++)
            {
                que.Enqueue(stk.Pop());
            }

            return que;
        }

        // 겹치는 숫자 판별메소드
        static List<int> MakeZeroNumTemp(List<int> zeroNumTemp, int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    if (i == 0)
                    {
                        if (j == 0)
                        {
                            if (arr[i, j] == arr[i + 1, j] || arr[i, j] == arr[i, j + 1] || arr[i, j] == arr[i, m])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (j == m - 1)
                        {
                            if (arr[i, j] == arr[i, 0] || arr[i, j] == arr[i, j - 1] || arr[i, j] == arr[i + 1, j])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (j > 0)
                        {
                            if (arr[i, j] == arr[i + 1, j] || arr[i, j] == arr[i, 0] || arr[i, j] == arr[i, j - 1])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                        }
                    }

                    else if (i == n - 1)
                    {
                        if (j == 0)
                        {
                            if (arr[i, j] == arr[i - 1, j] || arr[i, j] == arr[i, m - 1] || arr[i, j] == arr[i, j + 1])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (j == m - 1)
                        {
                            if (arr[i, j] == arr[i - 1, j] || arr[i, j] == arr[i, j - 1] || arr[i, j] == arr[i, 0])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (j > 0)
                        {
                            if (arr[i, j] == arr[i - 1, j] || arr[i, j] == arr[i, j - 1] || arr[i, j] == arr[i, j + 1])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                        }
                    }

                    else if (i > 0)
                    {
                        if (j == 0)
                        {
                            if (arr[i, j] == arr[i - 1, j] || arr[i, j] == arr[i + 1, j] || arr[i, j] == arr[i, j + 1] || arr[i, j] == arr[i, m - 1])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (j == m - 1)
                        {
                            if (arr[i, j] == arr[i - 1, j] || arr[i, j] == arr[i + 1, j] || arr[i, j] == arr[i, j - 1] || arr[i, j] == arr[i, 0])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                            else
                            {
                                continue;
                            }
                        }

                        if (j > 0)
                        {
                            if (arr[i, j] == arr[i - 1, j] || arr[i, j] == arr[i + 1, j] || arr[i, j] == arr[i, j - 1] || arr[i, j] == arr[i, j + 1])
                            {
                                zeroNumTemp.Add(i);
                                zeroNumTemp.Add(j);
                                continue;
                            }
                        }
                    }
                }
            }
            return zeroNumTemp;
        }
    }
}
