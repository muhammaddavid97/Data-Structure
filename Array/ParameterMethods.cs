using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ParameterMethods
    {

        public static void main()
        {
            // mendefinisikan array dengan tipe int
            int[] nilai = new int[] { 56, 78, 85, 93, 100 };

            Console.WriteLine("Menampilkan nilai : ");
            ParameterMethods.printNilai(nilai);

            Console.WriteLine("Nilai rata rata : " + ParameterMethods.hitungRataRata(nilai));

        }
        public static double hitungRataRata(int[] nilai)
        {
            int sumNilai = 0;
            for (int i = 0; i < nilai.Length; i++)
            {
                sumNilai += nilai[i];
            }

            double average = sumNilai / nilai.Length;

            return average;
        }

        public static void printNilai(int[] nilai)
        {
            for (int i = 0; i < nilai.Length; i++)
            {
                Console.WriteLine(nilai[i]);
            }
        }
    }
}
