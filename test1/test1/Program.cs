using System;
using System.Collections.Generic;
using System.Linq;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 5, 6, 3, 1, 2, 2, 3, 5, 6 };
            Console.WriteLine(SingleNumber(nums));
            Console.ReadKey();
        }

        public static int SingleNumber(int[] nums)
        {
            //Dictionary<int, int> contai = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    if (contai.ContainsKey(nums[i]))
            //    {
            //        int value = contai[nums[i]]++;
            //        contai.TryGetValue(nums[i], out value);
            //    }
            //    else
            //    {
            //        contai.Add(nums[i], 1);
            //    }
            //}
            //var keys = contai.SingleOrDefault(q => q.Value == 1).Key;
            //return keys;
            if (nums.Length <= 1) return nums[0];
            int result = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                result = result ^ nums[i];
            }
            return result;
        }
    }
}