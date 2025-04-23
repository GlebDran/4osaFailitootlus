using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4osaFailitootlus.ulesanned
{
    class FilmMain
    {
        static void Main()
        {
            // Создаём список фильмов
            List<Film> filmid = new List<Film>()
        {
            new Film("Inception", 2010, "Sci-Fi"),
            new Film("Titanic", 1997, "Drama"),
            new Film("The Matrix", 1999, "Sci-Fi"),
            new Film("Gladiator", 2000, "Action"),
            new Film("The Godfather", 1972, "Crime")
        };

            // 1. Найти фильмы по жанру
            Console.WriteLine("Sisesta žanr (Sci-Fi, Drama, Action, Crime):");
            string otsitavZanr = Console.ReadLine();

            List<Film> zanriFilmid = LeiaFilmidZanriJargi(filmid, otsitavZanr);
            Console.WriteLine($"\nFilmid žanrist '{otsitavZanr}':");
            foreach (Film film in zanriFilmid)
            {
                Console.WriteLine($"{film.Pealkiri} ({film.Aasta})");
            }

            // 2. Найти самый новый фильм
            Film uusimFilm = LeiaUusimFilm(filmid);
            Console.WriteLine($"\nUusim film: {uusimFilm.Pealkiri} ({uusimFilm.Aasta})");

            // 3. Группировка по жанрам
            var grupeeritud = GrupeeriFilmidZanriKaupa(filmid);
            Console.WriteLine("\nFilmid žanrite kaupa:");
            foreach (var paar in grupeeritud)
            {
                Console.WriteLine($"\nŽanr: {paar.Key}");
                foreach (Film film in paar.Value)
                {
                    Console.WriteLine($"- {film.Pealkiri} ({film.Aasta})");
                }
            }
        }

        // Функция для поиска фильмов по жанру
        static List<Film> LeiaFilmidZanriJargi(List<Film> filmid, string zanr)
        {
            return filmid.Where(f => f.Zanr.Equals(zanr, StringComparison.OrdinalIgnoreCase)).ToList();
        }

        // Функция для поиска самого нового фильма
        static Film LeiaUusimFilm(List<Film> filmid)
        {
            return filmid.OrderByDescending(f => f.Aasta).First();
        }

        // Функция для группировки фильмов по жанрам
        static Dictionary<string, List<Film>> GrupeeriFilmidZanriKaupa(List<Film> filmid)
        {
            return filmid.GroupBy(f => f.Zanr)
                         .ToDictionary(grupp => grupp.Key, grupp => grupp.ToList());
        }
    }
}
