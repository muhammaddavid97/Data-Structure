using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_1
    {
        public static void printOddNumber()
        {
            int[] oddNums = new int[10] {1,2,3,4,5,6,7,8,9,10};
            int sum = 0;

            for (int i = 0; i < oddNums.Length; i++)
            {
                if (oddNums[i] % 2 == 0)
                {
                    sum += oddNums[i];
                }
            }

            Console.WriteLine("Sum is : " + sum);
        }
    }
}
