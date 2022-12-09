using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicLogicalProblems
{
    internal class CouponNumber
    {
        public static int GenerateRandom()
        {
            Random random = new Random();
            int randomNum = random.Next(0, 11);
            return randomNum;
        }
        public static void GenerateCoupon()
        {
            Console.WriteLine("Enter Number:");
            int num = Convert.ToInt32(Console.ReadLine());  
            int[] arr = new int[num];
            for (int i = 0; i < arr.Length; i++)
            {
                int count = 0;
                int random = GenerateRandom();
                if (count == 0)
                {
                    arr[i] = random;
                }
                for (int j = 0; j < num; j++)
                {
                    if (arr[j] == random)
                    {
                        count++;
                    }
                }

            }
            foreach (var data in arr)
            {
                if (data != 0)
                {
                    Console.WriteLine(data);
                }
            }
        }


    }
}