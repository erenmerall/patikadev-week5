using System;
using System.Linq;

namespace ArrayPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1 - 10 adet tam sayı verisi alacak bir dizi tanımla
            int[] numbers = new int[10];

            // 2 - Diziyi for döngüsüyle doldur, foreach ile yazdır
            Console.WriteLine("10 adet sayı giriniz:");
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{i + 1}. sayı: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nDizinin elemanları:");
            foreach (int number in numbers)
            {
                Console.Write($"{number} - ");
            }

            // 3 - Kullanıcıdan alınan yeni bir değeri 11. eleman olarak ekle
            Console.Write("\nYeni bir sayı giriniz (11. eleman): ");
            int newNumber = int.Parse(Console.ReadLine());

            int[] extendedNumbers = new int[numbers.Length + 1];
            numbers.CopyTo(extendedNumbers, 0);
            extendedNumbers[extendedNumbers.Length - 1] = newNumber;

            // 4 - Diziyi büyükten küçüğe sıralayıp yazdır
            Console.WriteLine("\nDizi (Büyükten Küçüğe Sıralı):");
            Array.Sort(extendedNumbers);
            Array.Reverse(extendedNumbers);

            foreach (int number in extendedNumbers)
            {
                Console.Write($"{number} - ");
            }

            Console.ReadLine();
        }
    }
}
