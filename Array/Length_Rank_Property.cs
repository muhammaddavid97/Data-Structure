using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class Length_Rank_Property
    {
        //Length adalah property yang digunakan untuk menentukan jumlah elemen dari suatu array
        //Rank adalah property yang digunakan untuk menentukan jumlah dimensi dari suatu array

        public static void printEmployee()
        {
            string[] employee = new string[] { "rudi", "eka", "wisnu", "ariel" };

            // menentukan jumlah elemen pada array
            Console.WriteLine("Jumlah elemen : " + employee.Length);

            // menentukan jumlah dimensi pada array
            Console.WriteLine("Jumlah dimensi : " + employee.Rank);

            // property Length digunakan sebagai batas indeks dari pengulangan.
            for (int i = 0; i < employee.Length; i++)
            {
                Console.WriteLine("Nama karyawan : " + employee[i] + " ");
            }
        }

        public static void printStudents()
        {
            string[,] students = new string[,]
            {
                {"erik", "rudi" },
                { "bambang", "wahid"},
                {"iyus", "edi" },
                {"komar", "ratih" },
                {"galih", "uus" }
            };

            // menentukan jumlah elemen 
            Console.WriteLine("Jumlah elemen : " + students.Length);

            // menentukan jumlah dimensi 
            Console.WriteLine("Jumlah dimensi : " + students.Rank);

            // menampilkan isi dari array
            Console.WriteLine("Menampilkan isi dari array");
            for (int baris = 0; baris < 5; baris++)
            {
                for (int kolom = 0; kolom < 2; kolom++)
                {
                    Console.Write(students[baris, kolom] + " ");
                }

                Console.WriteLine();
            }
        }

        public static void printNumbers()
        {
            // property length pada jagged array digunakan untuk menghitung jumlah elemen setiap dimensi 
            // dengan demikian kita dapat mengetahui jumlah kolom pada masing" baris array

            int[][] numbers = new int[3][];

            numbers[0] = new int[2] { 1, 2 };
            numbers[1] = new int[4] { 3, 4, 5, 6 };
            numbers[2] = new int[3] { 7, 8, 9 };

            // menentukan jumlah dimensi 
            Console.WriteLine("Jumlah dimensi : " + numbers.Rank);

            // menentukan jumlah baris
            Console.WriteLine("Jumlah baris : " + numbers.Length);

            Console.WriteLine();

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Jumlah kolom pada baris ke - " + (i + 1) + " : " + numbers[i].Length );
            }

            Console.WriteLine("Menampilkan isi array ");
            for (int baris = 0; baris < numbers.Length; baris++)
            {
                for (int kolom = 0; kolom < numbers[baris].Length; kolom++)
                {
                    Console.Write(numbers[baris][kolom] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
