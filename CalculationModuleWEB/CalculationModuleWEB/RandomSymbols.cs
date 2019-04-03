using System;

namespace CalculationModuleUWP
{
    internal class RandomSymbols
    {
        internal static Random random = new Random();
        /// <summary>
        /// 随机整数
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static string Integer(int min,int max)
        {
            return random.Next(min, max).ToString();
        }
        /// <summary>
        /// 随机小数
        /// </summary>
        /// <param name="min1"></param>
        /// <param name="max1"></param>
        /// <param name="min2"></param>
        /// <param name="max2"></param>
        /// <returns></returns>
        internal static string Decimals(int min1,int max1,int min2,int max2)
        {
            return random.Next(min1, max1).ToString() + "." + random.Next(min2, max2);
        }
        /// <summary>
        /// 随机分数
        /// </summary>
        /// <param name="min1"></param>
        /// <param name="max1"></param>
        /// <param name="min2"></param>
        /// <param name="max2"></param>
        /// <returns></returns>
        internal static string Grade(int min1,int max1,int min2,int max2)
        {
            return random.Next(min1, max1).ToString() + "/" + random.Next(min2, max2);
        }
        /// <summary>
        /// 随机符号
        /// </summary>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        internal static string Operators(int min,int max)
        {
            switch (random.Next(min, max))
            {
                case 1:
                    return "＋";
                case 2:
                    return "－";
                case 3:
                    return "×";
                case 4:
                    return "÷";
            }
            return "";
        }
        //括号
        internal static void bracket()
        {

        }
    }
}
