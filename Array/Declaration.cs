using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Declaration
    {
        /*
         * Array adalah sekumpulan variable yang memiliki tipe yang sama 
         * Array di c# diimplementasikan sebagai objek sehingga perlu di implementasikan
         * Menggunakan kata kunci new untuk mendeklarasikan array di c#
         *
         *
         * Inisialisasi Array ; 
         * 
         * NamaArray = new tipe[jumlahElemen] atau tipe[]namaArray = new tipe[jumlahElemen]
         * tipe[] namaArray = new tipe[jumlahElemen] {elemen array[0], elemen array[namaArray.Length - 1]}
         * 
         */

        public static void declarationArrayToInt()
        {
            // deklarasikan array A bilangan bulat dengan jumlah 5 elemen
            int[] A = new int[5];
            int[] bilangan = new int[5] { 1, 2, 4, 8, 9 };
            int sum = 0;

            // inisialisasi array A 
            for (int i = 0; i < 5; i++)
            {
                A[i] = (i + 1) * 1000;
            }

            for (int i = 0; i < bilangan.Length; i++)
            {
                sum += bilangan[i];
            }

            Console.WriteLine("Menampilkan array A");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine((A[i] + " "));
            }
            
            Console.WriteLine("Jumlah bilangan : " + sum);
        }

        public static void declarationArrayToChar()
        {
            char[] A = new char[5];

            A[0] = 'a';
            A[1] = 'b';
            A[2] = 'c';
            A[3] = 'd';
            A[4] = 'e';

            Console.WriteLine("Menampilkan Array A dengan tipe char");
            for (int i = 0; i < A.Length; i++)
            {
                Console.WriteLine(A[i]);
            }
        }
    }
}
