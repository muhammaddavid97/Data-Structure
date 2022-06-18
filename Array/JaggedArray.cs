using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class JaggedArray
    {
        /*
         * Jagged array adalah array multidimensi dimana setiap barisnya memiliki jumlah kolom yang berbeda
         * jagged aray juga disebut sebagai array dari array(array yang setiap elemennya berupa array)
         * 
         * 
         * Deklarasi jagged array : 
         * tipe[][] namaArray = new tipe[jumlahBaris][]
         */

        public static void jaggedArrayBasic()
        {
            // mendeklarasikan 3 baris array
            int[][] JA = new int[3][];

            // membuat 2 kolom untuk baris pertama
            JA[0] = new int[2];

            // membuat 6 kolom untuk baris kedua
            JA[1] = new int[6];

            // membuat 4 kolom untuk baris ketiga
            JA[2] = new int[4];

            // inisialisasi nilai elemen pada baris pertama
            JA[0][0] = 1;
            JA[0][1] = 2;

            // inisialisasi nilai elemen pada baris kedua
            JA[1][0] = 3;
            JA[1][1] = 4;
            JA[1][2] = 5;
            JA[1][3] = 6;
            JA[1][4] = 7;
            JA[1][5] = 8;

            // inisialisasi nilai elemen pada baris ketiga
            JA[2][0] = 9;
            JA[2][1] = 10;
            JA[2][2] = 11;
            JA[2][3] = 12;

            // menampilkan setiap elemen pada array 
            for (int baris = 0; baris < 3; baris++)
            {
                // JA[baris].Length berfungsi untuk memperoleh jumlah kolom pada masing - masing baris
                for (int kolom = 0; kolom < JA[baris].Length; kolom++)
                {
                    Console.Write(JA[baris][kolom] + " ");
                }
                Console.WriteLine();
            }
        }

    }
}
