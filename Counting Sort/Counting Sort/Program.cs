using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counting_Sort
{
    class Program
    {
        public static void Counting_Sort(int[] dizi)
        {
            int min = dizi[0];
            int max = dizi[0];

            int[] siralidizi = new int[dizi.Length];
            for (int i = 1; i < dizi.Length; i++)
            {
                if (dizi[i] < min) min = dizi[i];
                else if (dizi[i] > max) max = dizi[i];
            }

            int[] sayac = new int[max - min + 1];

            for (int i = 0; i < dizi.Length; i++)
            {
                sayac[dizi[i] - min]++;
            }

            sayac[0]--;
            for (int i = 1; i < sayac.Length; i++)
            {
                sayac[i] = sayac[i] + sayac[i - 1];
            }

            for (int i = dizi.Length - 1; i >= 0; i--)
            {
                siralidizi[sayac[dizi[i] - min]--] = dizi[i];
            }

            Console.WriteLine("\n" + "Sıralanmış Dizi:");
            foreach (int l in siralidizi)
                Console.Write(l + " ");
            Console.Write("\n");

        }

        public static void Main()
        {
         
            Random rnd = new Random();

            int boyut = rnd.Next(2, 20);
            int[] dizi = new int[boyut];
            for (int i = 0; i < boyut; i++)
            {
                dizi[i] = rnd.Next(-50, 51); ;
            }


            Console.WriteLine("\n" + "Verilen Dizi :");
            foreach (int l in dizi)
                Console.Write(l + " ");

            Counting_Sort(dizi);

            Console.ReadLine();
        }
    }
}
