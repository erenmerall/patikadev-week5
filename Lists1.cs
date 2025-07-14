using System;
using System.Collections.Generic;

namespace PatikaPlusGala
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ziyaretçilerin isimlerini tutan liste
            List<string> visitors = new List<string>();

            Console.Write("Kaç ziyaretçi eklemek istiyorsunuz? ");
            int count = int.Parse(Console.ReadLine());

            // Listeye isim ekleme
            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{i}. ziyaretçi ismini giriniz: ");
                string name = Console.ReadLine();
                visitors.Add(name);
            }

            // Listeyi ekrana yazdırma
            Console.WriteLine("\nGala Gecesine Katılan Ziyaretçiler:");
            foreach (string visitor in visitors)
            {
                Console.WriteLine(visitor);
            }

            Console.ReadLine();
        }
    }
}
