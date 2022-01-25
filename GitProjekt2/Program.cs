using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitProjekt2
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba = new Osoba();

            Console.WriteLine("Zadej datum narození: ");

            osoba.DatumNarozeni = Convert.ToDateTime(DateTime.Parse(Console.ReadLine()));

            Console.WriteLine(osoba.Vek());

            Console.ReadKey();
        }
    }
}
