using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4osaFailitootlus.ulesanned
{
    class Film
    {
        public string Pealkiri { get; set; }
        public int Aasta { get; set; }
        public string Zanr { get; set; }

        public Film(string pealkiri, int aasta, string zanr)
        {
            Pealkiri = pealkiri;
            Aasta = aasta;
            Zanr = zanr;
        }
    }
}
