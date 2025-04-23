using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4osaFailitootlus.ulesanned
{
    class Valuuta
    {
        public string Nimetus { get; set; }         // Например, EUR, USD
        public double KurssEurSuhte { get; set; }   // Курс по отношению к EUR

        public Valuuta(string nimetus, double kurss)
        {
            Nimetus = nimetus;
            KurssEurSuhte = kurss;
        }
    }

}
