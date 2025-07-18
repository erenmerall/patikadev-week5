using System;

class Program
{
    static void Main(string[] args)
    {
        bool continueProgram = true;

        while (continueProgram)
        {
            Console.Write("Bir sayı giriniz: ");

            try
            {
                int number = Convert.ToInt32(Console.ReadLine());
                int square = number * number;
                Console.WriteLine($"Girdiğiniz sayının karesi: {square}");
            }
            catch
            {
                Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
            }

            Console.Write("Devam etmek istiyor musunuz? (e/h): ");
            string answer = Console.ReadLine().ToLower();

            if (answer != "e")
            {
                continueProgram = false;
            }
        }

        Console.WriteLine("\nProgram sonlandırıldı.");
    }
}
