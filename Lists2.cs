using System;
using System.Collections.Generic;

namespace CoffeeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> coffeeList = new List<string>();

            Console.WriteLine("Lütfen 5 farklı kahve ismi giriniz:");

            for (int i = 1; i <= 5; i++)
            {
                Console.Write($"{i}. kahve: ");
                string coffeeName = Console.ReadLine();
                coffeeList.Add(coffeeName);
            }

            Console.WriteLine("\nSeçilen Kahveler:");
            foreach (string coffee in coffeeList)
            {
                Console.WriteLine(coffee);
            }

            Console.ReadLine();
        }
    }
}
