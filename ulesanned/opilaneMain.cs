using System;
using System.Collections.Generic;
using System.Linq;

namespace _4osaFailitootlus.ulesanned
{
    class opilaneMain
    {
        static void Main()
        {
            // 1. Создаём учеников и их оценки
            List<opilane> klass = new List<opilane>()
            {
                new opilane("Kati") { Hinded = new List<int> {5, 4, 3, 5} },
                new opilane("Mati") { Hinded = new List<int> {2, 3, 4, 3} },
                new opilane("Juku") { Hinded = new List<int> {4, 4, 5, 5, 5} }
            };

            // 2. Выводим среднюю оценку каждого ученика
            Console.WriteLine("Õpilaste keskmised hinded:");
            foreach (opilane o in klass)
            {
                Console.WriteLine($"{o.Nimi} - {o.KeskmineHinne():F2}");
            }

            // 3. Находим ученика с самой высокой средней оценкой
            opilane parimOpilane = klass.OrderByDescending(o => o.KeskmineHinne()).First();
            Console.WriteLine($"\nKõrgeima keskmise hindega õpilane: {parimOpilane.Nimi} ({parimOpilane.KeskmineHinne():F2})");

            // 4. Бонус: сортируем учеников по средней оценке (по убыванию)
            Console.WriteLine("\nÕpilased järjestatud keskmise hinde järgi (kõrgeimast madalaimani):");
            foreach (opilane o in klass.OrderByDescending(o => o.KeskmineHinne()))
            {
                Console.WriteLine($"{o.Nimi} - {o.KeskmineHinne():F2}");
            }
        }
    }
}
