using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Lat_2
    {
        public static void sortingElemenArray()
        {
            int[] nums = new int[6] { 32, 11, 4, 22, 1, 67};

            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] > nums[j])
                    {
                        int swapp = nums[i];
                        nums[i] = nums[j];
                        nums[j] = swapp;
                    }
                }
            }

            Console.WriteLine("sesudah dilakukan sorting pada elemen array");
            for (int i = 0; i < nums.Length; i++)
            {
                Console.Write(nums[i] + " ");
            }
        }
    }
}
