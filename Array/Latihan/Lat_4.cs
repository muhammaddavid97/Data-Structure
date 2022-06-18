using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array.Latihan
{
    public class Lat_4
    {
        public static void palindromeBasic()
        {
            string word = "kasur ini rusak";
            string newWords = null;
            char[] splitWords = word.ToCharArray();

            int indeksFirst = 0;
            int lastIndeks = word.Length - 1;

            while (splitWords[indeksFirst] != splitWords[lastIndeks])
            {
                char swapp = splitWords[indeksFirst];
                splitWords[indeksFirst] = splitWords[lastIndeks];
                splitWords[lastIndeks] = swapp;

                indeksFirst += 1;
                lastIndeks -= 1;
            }

            newWords = String.Join("", splitWords);

            if (word == newWords)
            {
                Console.WriteLine("palindrome");
            }
            else
            {
                Console.WriteLine("bukan palindrome");
            }
        }
    }
}
