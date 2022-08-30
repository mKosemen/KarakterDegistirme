using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarakterDegistirme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string metin, sonuc="";
            string[] veri;
            Console.WriteLine("Bir metin giriniz.");
            metin = Console.ReadLine();
            veri = metin.Trim().Split(' ');
            foreach (var item in veri)
            {
                if (item.Length!=1)
                {
                    sonuc += item[item.Length - 1] + item.Remove(0, 1).Remove(item.Length - 2, 1) + item[0] + " ";
                }
                else
                {
                    sonuc += item + " ";
                }
            }
            Console.WriteLine(sonuc);

            Console.ReadLine();
        }
    }
}
