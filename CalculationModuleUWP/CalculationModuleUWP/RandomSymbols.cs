using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationModuleUWP
{
    internal class RandomSymbols
    { //随机整数
        internal static string integer(int scope)
        {
            Random random = new Random();
            return random.Next(0, scope).ToString();
        }
        //随机小数
        internal static string decimals(int scope)
        {
            Random random = new Random();
            return random.Next(0, scope).ToString() + "." + random.Next(1, 10);
        }
        //随机分数
        internal static string grade(int scope)
        {
            Random random = new Random();
            return random.Next(1, scope).ToString() + "/" + random.Next(1, 10);
        }
        //随机运算符      
        internal static string operators()
        {
            Random random = new Random();
            switch (random.Next(1, 5))
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
