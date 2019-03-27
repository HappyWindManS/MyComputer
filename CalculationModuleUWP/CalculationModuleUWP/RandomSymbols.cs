using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModuleUWP
{
    internal class RandomSymbols
    { //随机整数
        internal static string Integer(int min,int max)
        {
            Random random = new Random();
            return random.Next(min, max).ToString();
        }
        //随机小数
        internal static string Decimals(int min1,int max1,int min2,int max2)
        {
            Random random = new Random();
            return random.Next(min1, max1).ToString() + "." + random.Next(min2, max2);
        }
        //随机分数
        internal static string Grade(int min1,int max1,int min2,int max2)
        {
            Random random = new Random();
            return random.Next(min1, max1).ToString() + "/" + random.Next(min2, max2);
        }
        //随机运算符      
        internal static string Operators(int min,int max)
        {
            Random random = new Random();
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
