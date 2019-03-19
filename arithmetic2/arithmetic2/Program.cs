using System;
//哈希表
using System.Collections;
using System.Collections.Generic;

namespace arithmetic2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入要生成的题数");
            int quantity=int.Parse(Console.ReadLine());
            Console.WriteLine("请选择难度（输入1为四年级，整数运算，输入2为五年级，带有限小数运算，输入3为六年级,带分数运算)\n输入4混合运算，生成时间较久！");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine("请输入运算范围");
            int scope = int.Parse(Console.ReadLine());
            //利用哈希表进行数据的存储与查重
            Hashtable fourOperations= new Hashtable();
            switch(num)
            {
                case 1:
                    for (int i = 0; i < quantity; i++)
                    {
                        Console.WriteLine(topicfour(scope));
                    }
                    break;
                case 2:
                    for (int i = 0; i < quantity; i++)
                    {
                        topicfive(scope);
                    }
                    break;
                case 3:
                    for (int i = 0; i < quantity; i++)
                    {
                        topicssix(scope);
                    }
                    break;
                case 4:
                    for (int i = 0; i < quantity; i++)
                    {
                        mixture(scope);
                    }
                    break;
            }
            Console.ReadKey();
        }
        //生成四年级题目
        public static string topicfour(int scope)
        {
            string ret;
            ret = integer(scope) + " " + operators() + " " + integer(scope) + " " + operators() + " " + integer(scope) + " =";
            return ret;
        }
        //生成五年级题目
        public static string topicfive(int scope)
        {
            string ret;
            ret = decimals(scope) + " " + operators() + " " + decimals(scope) + " " + operators() + " " + decimals(scope) + " =";
            return ret;
        }
        //生成六年级题目
        public static string topicssix(int scope)
        {
            string ret;
            ret = grade(scope) + " " + operators() + " " + grade(scope) + " " + operators() + " " + grade(scope) + " =";
            return ret;
        }
        //生成混合题目
        public static string mixture(int scope)
        {
            string ret = "";
            Random random = new Random();
            for(int i=0;i<3;i++)
            {              
                switch (random.Next(1,3))
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
                    ret+= operators();
                }
            }
            return ret;
        }

        //随机整数
        public static string integer(int scope)
        {
            Random random = new Random();
            return random.Next(0, scope).ToString();
        }
        //随机小数
        public static string decimals(int scope)
        {
            Random random = new Random();
            return random.Next(0, scope).ToString()+"."+ random.Next(1, 10);
        }
        //随机分数
        public static string grade(int scope)
        {
            Random random = new Random();
            return random.Next(1, scope).ToString() + "/" + random.Next(1, 10);
        }
        //随机运算符      
        public static string operators()
        {
            Random random = new Random();
            switch(random.Next(1, 5))
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
        //正常运算
        public static int operation(string symbol,int num1,int num2)
        {
            switch (symbol)
            {
                case "＋":
                    return num1+num2;
                case "－":
                    return num1-num2;
                case "×":
                    return num1*num2;
                case "÷":
                    return num2/num2;
            }
            return 0;
        }
        //分数运算
        public static string operation(string symbol,string num1,string num2)
        {

            return "";
        }
    }
}
