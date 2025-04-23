using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        // 1. Определяем путь к файлу Kuud.txt
        string path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\Kuud.txt");

        // 2. Записываем 3 месяца в файл (перезаписываем каждый раз для чистоты примера)
        using (StreamWriter sw = new StreamWriter(path, true))
        {
            sw.WriteLine("Jaanuar");
            sw.WriteLine("Veebruar");
            sw.WriteLine("Juuni");
        }

        // 3. Читаем месяцы в List<string>
        List<string> kuud = new List<string>();
        try
        {
            foreach (string rida in File.ReadAllLines(path))
            {
                kuud.Add(rida);
            }
        }
        catch (Exception)
        {
            Console.WriteLine("Viga faili lugemisel!");
            return;
        }

        // 4. Удаляем "Juuni" и меняем первый элемент
        kuud.Remove("Juuni");

        if (kuud.Count > 0)
            kuud[0] = "Detsember"; // Меняем первый элемент

        // 5. Выводим все месяцы
        Console.WriteLine("Kõik kuud failist:");
        foreach (string kuu in kuud)
        {
            Console.WriteLine(kuu);
        }

        // 6. Даем пользователю возможность искать месяц
        Console.WriteLine("Sisesta kuu nimi, mida otsida:");
        string otsitav = Console.ReadLine();

        if (kuud.Contains(otsitav))
            Console.WriteLine("Kuu " + otsitav + " on olemas.");
        else
            Console.WriteLine("Sellist kuud pole.");

        // 7. Сохраняем изменённый список обратно в файл
        try
        {
            File.WriteAllLines(path, kuud);
            Console.WriteLine("Andmed on salvestatud.");
        }
        catch (Exception)
        {
            Console.WriteLine("Viga faili salvestamisel!");
        }
    }
}
