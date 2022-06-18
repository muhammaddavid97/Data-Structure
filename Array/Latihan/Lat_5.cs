using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_5
    {
        public static void printJaggedArray()
        {
            string[][] names = new string[3][];

            names[0] = new string[2] { "rudi", "eko" };
            names[1] = new string[1] { "hendrik" };
            names[2] = new string[4] { "mahmud", "idam", "yusril", "jajang" };

            for (int baris = 0; baris < 3; baris++)
            {
                for (int kolom = 0; kolom < names[baris].Length; kolom++)
                {
                    Console.Write(names[baris][kolom] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
