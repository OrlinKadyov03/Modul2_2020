using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Word_4_Правоъгълник
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = double.Parse(Console.ReadLine());
           double b = double.Parse(Console.ReadLine());


            double s = a * b;
            double p = 2 * a + 2 * b;
            double c = Math.Sqrt(Math.Pow(a, 2) + b * b);
            decimal c1 =(decimal) Math.Sqrt(Math.Pow(a,2) + b * b);
            

            Console.WriteLine(s);
            Console.WriteLine(p);
            Console.WriteLine(c);
            Console.WriteLine(c1);

        }
    }
}
