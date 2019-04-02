using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModuleUWP
{
    public class RandomTopic
    {
        internal static Random random = new Random();
        /// <summary>
        /// 一年级
        /// </summary>
        public static string FirstGrade()
        {
            return RandomSymbols.Integer(0, 20) + RandomSymbols.Operators(1, 3) + RandomSymbols.Integer(0, 20);
        }
        /// <summary>
        /// 二年级
        /// </summary>
        /// <returns></returns>
        public static string SecondGrade()
        {
            return RandomSymbols.Integer(10, 100) + RandomSymbols.Operators(1,3) + RandomSymbols.Integer(10, 100);

        }
        /// <summary>
        /// 三年级
        /// </summary>
        /// <returns></returns>
        public static string ThreeGrade()
        {
            return RandomSymbols.Integer(10, 100) + RandomSymbols.Operators(3, 5) + RandomSymbols.Integer(10, 100);
        }
        /// <summary>
        /// 四年级
        /// </summary>
        /// <returns></returns>
        public static string FourGrade()
        {
            string equation = RandomSymbols.Integer(1, 1000);
            for (int i=0;i<3;i++)
            {
                equation += RandomSymbols.Operators(1, 5) + RandomSymbols.Integer(1, 1000) ;
            }
            return equation;
        }
        /// <summary>
        /// 五年级
        /// </summary>
        /// <returns></returns>
        public static string FiveGrade()
        {
            Random random = new Random();
            if(random.Next(1,3)==1)
            {
                return RandomSymbols.Decimals(1, 100, 1, 100) + RandomSymbols.Operators(1, 5) + RandomSymbols.Integer(1, 100);
            }
            if (random.Next(1, 3) == 2)
            {
                return RandomSymbols.Integer(1, 100) + RandomSymbols.Operators(1, 5) + RandomSymbols.Decimals(1, 100, 1, 100);
            }

            return RandomSymbols.Decimals(1,100,1,100) + RandomSymbols.Operators(1, 5) + RandomSymbols.Decimals(1, 100, 1, 100);
        }
        /// <summary>
        /// 六年级
        /// </summary>
        /// <returns></returns>
        public static string SixGrade()
        {
            string ret = RandomDigit(0,3);
            for(int i=0;i<random.Next(2,4);i++)
            {
                ret += RandomSymbols.Operators(1,5) + RandomDigit(0, 3);
            }
            return ret;
        }
        /// <summary>
        /// 随机题目
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static string RandomDigit(int min,int max)
        {
            switch(random.Next(min,max))
            {
                case 0:
                    return RandomSymbols.Integer(1, 100);
                case 1:
                    return RandomSymbols.Decimals(0, 10, 1, 10);
                case 2:
                    return RandomSymbols.Grade(1, 10, 2, 10);
            }
            return "";
        }
    }
}
