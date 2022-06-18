using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_3
    {
        public static void printDiagonalSame()
        {
            int[,] bilangan = new int[4, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 }, { 11, 12, 13 } };

            for (int baris = 0; baris < 4; baris++)
            {
                for (int kolom = 0; kolom < 3; kolom++)
                {
                    if (baris == kolom)
                    {
                        bilangan[baris, kolom] = baris + 1;
                    }

                    Console.Write(bilangan[baris, kolom] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
