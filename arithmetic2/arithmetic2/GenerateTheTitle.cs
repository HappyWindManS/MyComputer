using System;
using System.Collections.Generic;
using System.Text;

namespace arithmetic2
{
    /// <summary>
    /// 生成题目
    /// </summary>
    public class generateTheTitle
    {
        //生成四年级题目
        public static string topicfour(int scope)
        {
            string ret;
            ret = NumbersAndSymbols.integer(scope) + " " + NumbersAndSymbols.operators() + " " + NumbersAndSymbols.integer(scope) + " " + NumbersAndSymbols.operators() + " " + NumbersAndSymbols.integer(scope);
            return ret;
        }
        //生成五年级题目
        public string topicfive(int scope)
        {
            string ret;
            ret = NumbersAndSymbols.decimals(scope) + " " + NumbersAndSymbols.operators() + " " + NumbersAndSymbols.decimals(scope) + " " + NumbersAndSymbols.operators() + " " + NumbersAndSymbols.decimals(scope);
            return ret;
        }
        //生成六年级题目
        public string topicssix(int scope)
        {
            string ret;
            ret = NumbersAndSymbols.grade(scope) + " " + NumbersAndSymbols.operators() + " " + NumbersAndSymbols.grade(scope) + " " + NumbersAndSymbols.operators() + " " + NumbersAndSymbols.grade(scope);
            return ret;
        }
        //生成混合题目
        public string mixture(int scope)
        {
            string ret = "";
            Random random = new Random();
            for (int i = 0; i < 3; i++)
            {
                switch (random.Next(1, 4))
                {
                    case 1:
                        ret += NumbersAndSymbols.integer(scope);
                        break;
                    case 2:
                        ret += NumbersAndSymbols.decimals(scope);
                        break;
                    case 3:
                        ret += NumbersAndSymbols.grade(scope);
                        break;
                }
                if (i != 2)
                {
                    ret += NumbersAndSymbols.operators();
                }
            }
            return ret;
        }
    }
}
