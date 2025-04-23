using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4osaFailitootlus.ulesanned
{
    class opilane
    {
        public string Nimi { get; set; }
        public List<int> Hinded { get; set; }

        public opilane(string nimi)
        {
            Nimi = nimi;
            Hinded = new List<int>();
        }

        // Метод для подсчёта среднего балла
        public double KeskmineHinne()
        {
            return Hinded.Average();
        }
    }
}
