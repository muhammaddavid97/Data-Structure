using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_7
    {
        public static void printStudents()
        {
            Students[] listStudents = new Students[4];

            for (int i = 0; i < listStudents.Length; i++)
            {
                listStudents[i] = new Students();
            }

            listStudents[0].FirstName = "juhana";
            listStudents[0].LastName = "rukini";
            listStudents[0].Age = 21;

            listStudents[1].FirstName = "muhammad";
            listStudents[1].LastName = "edi";
            listStudents[1].Age = 15;

            listStudents[2].FirstName = "kurniawan";
            listStudents[2].LastName = "dwi cahyono";
            listStudents[2].Age = 19;

            listStudents[3].FirstName = "sofian";
            listStudents[3].LastName = "silite";
            listStudents[3].Age = 33;

            Console.WriteLine("Menampilkan daftar student");

            foreach(var item in listStudents)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }

    class Students
    {
        private string firstName;
        private string lastName;
        private int age;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }

        public override string? ToString()
        {
            return $"Nama lengkap : {FirstName} {LastName} \n" +
                $"Usia : {Age}";
        }
    }
}
