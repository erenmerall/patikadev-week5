using System;
using System.Collections.Generic;

namespace CarFactory
{
    class Car
    {
        public DateTime ProductionDate { get; set; }
        public string SerialNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> carList = new List<Car>();

            while (true)
            {
                Console.Write("Araba üretmek istiyor musunuz? (e/h): ");
                string answer = Console.ReadLine().ToLower();

                if (answer == "h")
                {
                    break;
                }
                else if (answer != "e")
                {
                    Console.WriteLine("Geçersiz cevap! Lütfen sadece 'e' ya da 'h' giriniz.\n");
                    continue;
                }

                // Yeni araba nesnesi oluşturuluyor
                Car car = new Car();

                car.ProductionDate = DateTime.Now;

                Console.Write("Seri Numarası giriniz: ");
                car.SerialNumber = Console.ReadLine();

                Console.Write("Marka giriniz: ");
                car.Brand = Console.ReadLine();

                Console.Write("Model giriniz: ");
                car.Model = Console.ReadLine();

                Console.Write("Renk giriniz: ");
                car.Color = Console.ReadLine();

            DoorCountInput:
                Console.Write("Kapı sayısı giriniz: ");
                string doorInput = Console.ReadLine();
                int doorCount;

                if (!int.TryParse(doorInput, out doorCount))
                {
                    Console.WriteLine("Hatalı giriş! Lütfen sayısal bir değer giriniz.");
                    goto DoorCountInput;
                }

                car.DoorCount = doorCount;

                carList.Add(car);

                Console.WriteLine("Araba başarıyla üretildi!\n");
            }

            Console.WriteLine("\nÜretilen Arabalar:");
            foreach (var item in carList)
            {
                Console.WriteLine($"Seri No: {item.SerialNumber} - Marka: {item.Brand} - Model: {item.Model} - Renk: {item.Color} - Kapı Sayısı: {item.DoorCount} - Üretim Tarihi: {item.ProductionDate}");
            }

            Console.WriteLine("\nProgram sonlandırıldı.");
        }
    }
}
