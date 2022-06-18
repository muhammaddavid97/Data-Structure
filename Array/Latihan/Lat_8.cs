using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_8
    {
        public static void printDosen()
        {
            Dosen[] listDosen = new Dosen[]
            {
                new Dosen("Jauhari", "malik", 22, 34.5000000),
                new Dosen("Erik", "kurniawan", 16, 20.0000),
                new Dosen("Opie", "kumis", 19, 100.0000),
                new Dosen("Zizie", "michael", 25, 210.000)
            };

            // mengurutkan data dosen berdasarkan usia
            for (int i = 0; i < listDosen.Length - 1; i++)
            {
                for (int j = i + 1; j < listDosen.Length; j++)
                {
                    if (listDosen[i].Age > listDosen[j].Age)
                    {
                        int swapp = listDosen[i].Age;
                        listDosen[i].Age = listDosen[j].Age;
                        listDosen[j].Age = swapp;
                    }
                }
            }


            foreach (var item in listDosen)
            {
                Console.WriteLine(item.ToString());
            }

            
        }
    }

    class Dosen
    {
        private string firstName;
        private string lastName;
        private int age;
        private double gaji;

        public Dosen(string firstName, string lastName, int age, double gaji)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.gaji = gaji;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public double Gaji { get => gaji; set => gaji = value; }

        public override string? ToString()
        {
            return $"Nama lengkap : {FirstName} {LastName} \n" +
                $"Age : {Age} \n" +
                $"Gaji :  ${Gaji}";
        }
    }
}
