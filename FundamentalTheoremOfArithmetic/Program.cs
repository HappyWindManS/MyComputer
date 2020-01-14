using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace FundamentalTheoremOfArithmetic
{
    class Program
    {
        public int[] stack = new int[2];
        public static List<int> prime = new List<int>();
        public static StringBuilder stringBuilder = new StringBuilder();
        static void Main(string[] args)
        {
            GetPrime();
            Console.WriteLine("唯一析因定理是一个有趣的东西");
            Console.WriteLine("它能将一个合数分解为一个又一个质数");
            Console.WriteLine("这是数论的内容");
            Console.WriteLine("比如，");
            Resolve(9, prime);
            Console.WriteLine(stringBuilder);
            Console.ReadLine();
        }

        public static void GetPrime()
        {
            for(int i=0;i<100000;i++)
            {
                for (int j = 2; j < i/2+1; j++)
                {
                    //当 i 可以被 j 整除时跳出该循环,该数不是素数,不做输出
                    if (i % j == 0)
                    {
                        if (!prime.Contains(j))
                        {
                            prime.Add(j);
                        }
                        break;
                    }
                }
            }
        }
        public static int Resolve(int num, List<int> prime)
        {
            if (prime.Contains(num)||num==1)
            {
                stringBuilder.Append(num.ToString());
                return num;
            }
            else
            {
                foreach (var a in prime)
                {
                    if (num % a == 0)
                    {
                        num = num / a;
                        stringBuilder.Append(a.ToString() + "*");
                    }
                }
                return Resolve(num,prime);
            }
        }
    }
}
