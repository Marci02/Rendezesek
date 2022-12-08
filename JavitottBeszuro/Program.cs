using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JavitottBeszuro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Javított beszuró rendezés");

            int[] tomb = new int[] { 5, 3, 10, 6, 1, 2, 4, 8 };

            for (int i = 1; i < tomb.Length; i++)
            {
                int j = i - 1;
                int temp = tomb[i];
                while (j >= 0 && tomb[j] > temp)
                {
                    tomb[j + 1] = tomb[j];
                    j--;
                }
                tomb[j + 1] = temp;
            }




            foreach (var t in tomb)
            {
                Console.Write($" {t}");
            }



            Console.ReadKey();
        }
    }
}
