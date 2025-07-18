using System;
using System.Collections.Generic;
using System.Linq;

namespace ImdbMovieList
{
    class Movie //filmlerin özelliklerini tutan sınıf
    {
        public string Name { get; set; }
        public double ImdbRating { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Movie> movieList = new List<Movie>();
            bool continueAdding = true;

            while (continueAdding) 
            {
                Console.Write("Film adı giriniz: ");
                string name = Console.ReadLine();

                Console.Write("IMDB puanını giriniz: ");
                double imdbRating = Convert.ToDouble(Console.ReadLine());

                movieList.Add(new Movie { Name = name, ImdbRating = imdbRating }); // Film nesnesi oluşturulup listeye ekleniyor

                Console.Write("Yeni bir film eklemek istiyor musunuz? (e/h): ");
                string answer = Console.ReadLine().ToLower();

                if (answer != "e")
                {
                    continueAdding = false;
                }
            }

            Console.WriteLine("\nTüm Filmler:");
            foreach (var movie in movieList)
            {
                Console.WriteLine($"Film: {movie.Name} - IMDB: {movie.ImdbRating}");
            }

            Console.WriteLine("\nIMDB puanı 4 ile 9 arasında olan filmler:");
            foreach (var movie in movieList.Where(m => m.ImdbRating >= 4 && m.ImdbRating <= 9))
            {
                Console.WriteLine($"Film: {movie.Name} - IMDB: {movie.ImdbRating}");
            }

            Console.WriteLine("\nAdı 'A' harfi ile başlayan filmler:");
            foreach (var movie in movieList.Where(m => m.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine($"Film: {movie.Name} - IMDB: {movie.ImdbRating}");
            }

        }
    }
}
