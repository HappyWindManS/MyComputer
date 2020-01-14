using System;
using System.Collections;

namespace FundamentalTheoremOfArithmetic
{
    class Program
    {
        public Stack stack = new Stack();
        public static Stack prime = new Stack();
        static void Main(string[] args)
        {
            GetPrime();
            Console.WriteLine("唯一析因定理是一个有趣的东西");
            Console.WriteLine("它能将一个分解为一个又一个质数");
            Console.WriteLine("这是初等数论的内容");
            Console.WriteLine("比如，");
        }

        public static void GetPrime()
        {
            for(int i=0;i<10000;i++)
            {
                for (int j = 2; j < i/2; j++)
                {
                    //当 i 可以被 j 整除时跳出该循环,该数不是素数,不做输出
                    if (i % j == 0)
                    {
                        prime.Push(j);
                        break;
                    }
                }
            }
        }

        public int Resolve(int num)
        {
            if(prime.Contains(num))
            {
                return num;
            }
            else
            {

                return Resolve(num);
            }
        }
    }
}
