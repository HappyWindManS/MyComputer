using System;

namespace MathematicalModeling
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("开始进行生产");
        }

        public static void GetQuantity()
        {

        }
        //车的品牌
        public static string[,] brand()
        {
            string[,] brand = new string[2, 2];
            brand[0, 0] = "A1";
            brand[1, 0] = "A2";
            return brand;
        }

        //配置
        public static string[,] configuration()
        {
            string[,] configuration = new string[6, 2];
            configuration[0, 0] = "B1";
            configuration[1, 0] = "B2";
            configuration[2, 0] = "B3";
            configuration[3, 0] = "B4";
            configuration[4, 0] = "B5";
            configuration[5, 0] = "B6";
            return configuration;
        }

        //动力
        public static string[,] power()
        {
            string[,] power = new string[2, 2];
            power[0, 0] = "汽油";
            power[1, 0] = "柴油";
            return power;
        }

        //驱动
        public static string[,] drive()
        {
            string[,] drive = new string[2, 2];
            drive[0, 0] = "两驱";
            drive[1, 0] = "四驱";
            return drive;
        }

        //颜色
        public static string[,] color()
        {
            string[,] color = new string[9, 2];
            color[0, 0] = "黑";
            color[1, 0] = "黑";
            color[2, 0] = "黑";
            color[3, 0] = "黑";
            color[4, 0] = "黑";
            color[5, 0] = "黑";
            color[6, 0] = "黑";
            color[7, 0] = "黑";
            color[8, 0] = "黑";
            return color;
        }

        public static void test()
        {

        }
        public static void ManyModels()
        {

        }
    }
}