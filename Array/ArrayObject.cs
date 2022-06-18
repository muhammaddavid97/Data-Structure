using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ArrayObject
    {

        public static void displayArrayOfObject()
        {
            // mendefinisikan array dimana elemennya berupa objek dari kelas SegiEmpat
            SegieEmpat[] luas = new SegieEmpat[3];

            // inisialisasi elemen pertama dengan objek dari kelas SegiEmpat
            luas[0] = new SegieEmpat();

            luas[0].panjang = 10;
            luas[0].lebar = 11;
            double hitungLuas1 = luas[0].hitungLuas();

            // inisialisasi elemen kedua dengan objek dari kelas SegiEmpat
            luas[1] = new SegieEmpat();

            luas[1].panjang = 5;
            luas[1].lebar = 1;
            double hitungLuas2 = luas[1].hitungLuas();

            // inisialisasi elemen ketiga dengan objek dari kelas SegiEmpat
            luas[2] = new SegieEmpat();

            luas[2].panjang = 3;
            luas[2].lebar = 10;
            double hitungLuas3 = luas[2].hitungLuas();

            // menampilkan luas dari masing masing elemen 
            int i = 0;
            foreach(var item in luas)
            {
                Console.WriteLine("Luas segiempat pada A [ " + i + " ] = " + item.hitungLuas());
                i++;
            }
        }
        
    }

    class SegieEmpat
    {
        public double panjang;
        public double lebar;
        public double hitungLuas()
        {
            return panjang * lebar;
        }
    }
}
