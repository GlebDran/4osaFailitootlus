using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4osaFailitootlus.ulesanned
{
    class valuutaMain
    {
        public static void Main()
        {
            // Создаём список валют
            List<Valuuta> valuutad = new List<Valuuta>()
        {
            new Valuuta("EUR", 1.0),
            new Valuuta("USD", 1.1),   // 1 EUR = 1.1 USD
            new Valuuta("GBP", 0.85),  // 1 EUR = 0.85 GBP
            new Valuuta("JPY", 130.0)  // 1 EUR = 130 JPY
        };

            // Для бонуса — словарь для быстрого поиска
            Dictionary<string, Valuuta> valuutaDict = new Dictionary<string, Valuuta>();
            foreach (var val in valuutad)
            {
                valuutaDict.Add(val.Nimetus, val);
            }

            // Основной цикл программы
            while (true)
            {
                Console.WriteLine("\nVali tegevus:");
                Console.WriteLine("1 - Arvuta valuutast EUR-iks");
                Console.WriteLine("2 - Arvuta EUR-ist valuutaks");
                Console.WriteLine("0 - Välju");
                string valik = Console.ReadLine();

                if (valik == "0")
                    break;

                Console.WriteLine("Sisesta valuuta nimetus (EUR, USD, GBP, JPY):");
                string nimetus = Console.ReadLine().ToUpper();

                if (!valuutaDict.ContainsKey(nimetus))
                {
                    Console.WriteLine("Sellist valuutat pole!");
                    continue;
                }

                Console.WriteLine("Sisesta summa:");
                double summa = double.Parse(Console.ReadLine());

                if (valik == "1")
                {
                    // Valuutast EUR-iks
                    double eurSumma = summa / valuutaDict[nimetus].KurssEurSuhte;
                    Console.WriteLine($"{summa} {nimetus} = {eurSumma:F2} EUR");
                }
                else if (valik == "2")
                {
                    // EUR-ist valuutaks
                    double valuutaSumma = summa * valuutaDict[nimetus].KurssEurSuhte;
                    Console.WriteLine($"{summa} EUR = {valuutaSumma:F2} {nimetus}");
                }
                else
                {
                    Console.WriteLine("Vale valik!");
                }
            }
        }
    }
}
