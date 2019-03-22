using System;
using System.Collections.Generic;
using System.Text;

namespace arithmetic2
{
    /// <summary>
    /// 生成随机符号与随机数
    /// </summary>
    public class NumbersAndSymbols
    {
        //随机整数
        public string integer(int scope)
        {
            Random random = new Random();
            return random.Next(0, scope).ToString();
        }
        //随机小数
        public string decimals(int scope)
        {
            Random random = new Random();
            return random.Next(0, scope).ToString() + "." + random.Next(1, 10);
        }
        //随机分数
        public string grade(int scope)
        {
            Random random = new Random();
            return random.Next(1, scope).ToString() + "/" + random.Next(1, 10);
        }
        //随机运算符      
        public string operators()
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
        public static void bracket()
        {

        }
    }
}
