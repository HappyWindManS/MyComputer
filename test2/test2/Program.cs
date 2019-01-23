using System;

namespace test2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] aa = new int[9] { 1,2,3,3,2,5,5,6,6};
            Console.WriteLine(OnlyAFew(aa)[0]);
            Console.ReadKey();
        }
        
        public static int[] OnlyAFew(int[] vs)
        {
            foreach(var item in vs)
            {
                foreach(var item2 in vs)
                {
                    if(item==item2)
                    {
                        break;
                    }
                    vs[0] = item;
                }
            }return vs;
        }
    }
}
