using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Osoba
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }
        public DateTime DatumNarozeni { get; set; }

        public int Vek()
        {
            DateTime date = DateTime.Now;

            Console.WriteLine(date.Second);
            Console.ReadKey();

            return date.Year - DatumNarozeni.Year;
        }
    }
}
