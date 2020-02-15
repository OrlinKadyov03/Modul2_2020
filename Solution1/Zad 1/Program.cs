using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zad_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int centery = int.Parse(Console.ReadLine());
            int years = centery * 100;
            int days = (int)(years * 365.2422);
            int hours = 24 * days;
            int minutes = 60 * hours;
            Console.WriteLine("{0}centuries = {1} years = {2} days = {3} hours = {4} minutes", centery, years, days, hours, minutes);
            Console.Write("Centery = ");

        }
    }
}
