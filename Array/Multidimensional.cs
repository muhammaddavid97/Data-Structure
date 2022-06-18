using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Multidimensional
    {
        /*
         * Array multidimensional adalah array yang memiliki lebih dari satu dimensi.
         * 
         * 
         * mendeklarasikan array dua dimensi 
         * tipe[,] nameArray = new tipe[jumlahBaris, jumlahKolom]
                    
         */

        public static void printArrayDuaDimensi()
        {
            // mendeklarasikan array dua dimensi dengan 4 baris dan 3 kolom
            int[,] bilangan = new int[4, 3];

            // inisialisasi array dua dimensi
            
            //kolom pertama
            bilangan[0, 0] = 1;
            bilangan[1, 0] = 2;
            bilangan[2, 0] = 3;
            bilangan[3, 0] = 4;
            // kolom kedua
            bilangan[0, 1] = 5;
            bilangan[1, 1] = 4;
            bilangan[2, 1] = 2;
            bilangan[3, 1] = 3;
            // kolom ketiga
            bilangan[0, 2] = 3;
            bilangan[1, 2] = 1;
            bilangan[2, 2] = 4;
            bilangan[3, 2] = 2;


            // menampilkan elemen array dua dimensi
            for (int baris = 0; baris < 4; baris++)
            {
                // mencetak perbaris
                for (int kolom = 0; kolom < 3; kolom++)
                {
                    Console.Write(bilangan[baris, kolom] + " ");
                }

                Console.WriteLine();
            }
        }
    }
}
