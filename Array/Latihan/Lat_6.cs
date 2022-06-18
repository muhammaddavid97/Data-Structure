using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_6
    {
        public static void sumArrayMultidimensi()
        {
            int[,] nums = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9} };
            int sum1 = 0;

            for (int baris = 0; baris < 3; baris++)
            {
                //sum1 = 0;
                for (int kolom = 0; kolom < 3; kolom++)
                {
                    if (baris == kolom)
                    {
                        sum1 += nums[baris, kolom];
                    }

                    if (baris > kolom && kolom != 1)
                    {
                        nums[baris, kolom]++;
                    }

                    if (baris != kolom)
                    {
                        nums[baris, kolom] = 1;
                    }

                    Console.Write(nums[baris, kolom] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("sum is : " + sum1);
        }
    }
}
