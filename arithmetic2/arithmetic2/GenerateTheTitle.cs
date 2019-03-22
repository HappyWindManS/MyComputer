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
            ret = integer(scope) + " " + operators() + " " + integer(scope) + " " + operators() + " " + integer(scope);
            return ret;
        }
        //生成五年级题目
        public string topicfive(int scope)
        {
            string ret;
            ret = decimals(scope) + " " + operators() + " " + decimals(scope) + " " + operators() + " " + decimals(scope);
            return ret;
        }
        //生成六年级题目
        public string topicssix(int scope)
        {
            string ret;
            ret = grade(scope) + " " + operators() + " " + grade(scope) + " " + operators() + " " + grade(scope);
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
                        ret += integer(scope);
                        break;
                    case 2:
                        ret += decimals(scope);
                        break;
                    case 3:
                        ret += grade(scope);
                        break;
                }
                if (i != 2)
                {
                    ret += operators();
                }
            }
            return ret;
        }
    }
}
