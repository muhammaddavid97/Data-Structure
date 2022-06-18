using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
    public class ForEach
    {
        /*
         * foreach digunakan untuk menelusuri setiap elemen yang ada pada collection (sekumpulan objek) termasuk array
         * dalam proses penelusuran diperlukan variable bantu untuk menampung nilai pada masing" elemen.
         */

        public static void printEmployee(string[] names)
        {
            foreach(var item in names)
            {
                Console.WriteLine("Nama karyawan : " + item);
            }
        }

        public static void main()
        {
            string[] names = new string[] { "rudi", "eka", "yudi", "yanuar" };
            ForEach.printEmployee(names);
        }
    }
}
