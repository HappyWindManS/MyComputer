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
        public static Hashtable hashtable = new Hashtable();
        static void Main(string[] args)
        {
            Console.WriteLine("唯一析因定理是一个有趣的东西");
            Console.WriteLine("它能将一个合数分解为一个又一个质数");
            Console.WriteLine("这是数论的内容");
            Console.WriteLine("比如，");
            Resolve(864531);
            foreach(var str in hashtable.Keys)
            {
                Console.WriteLine("{0}^{1}",str,hashtable[str]);
            }
            Console.ReadLine();
        }

        /// <summary>
        /// 判断素数
        /// </summary>
        /// <param name="num"></param>
        /// <returns></returns>
        public static int BoolGetPrime(int num)
        {
            for (int j = 2; j < num/2; j++)
            {
                //当 i 可以被 j 整除时跳出该循环,该数不是素数,不做输出
                if (num % j == 0)
                {
                    return j;
                }             
            }
            return 0;
        }
        public static int Resolve(int num)
        {
            int m = BoolGetPrime(num);
            if (hashtable.Contains(m))
            {
                hashtable[m] = (int)hashtable[m] + 1;
                return Resolve(num / m);           
            }
            else if (m == 0)
            {
                hashtable.Add(num, 1);
                return num;
            }
            else 
            {
                hashtable.Add(m, 1);
                return Resolve(num/m);
            }
        }
    }
}
