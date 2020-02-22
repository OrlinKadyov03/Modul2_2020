using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Word_1SumMaxMid
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            Console.WriteLine(string.Join(" ",num));
            int sumEl = num.Sum();
            Console.WriteLine($" sum={sumEl}");

            int maxEl = num.Max();
            Console.WriteLine($" max={maxEl}");

            int minEl = num.Min();
            Console.WriteLine($" min={minEl}");
            double aveEl = num.Average();
            Console.WriteLine($" ave={aveEl:f2}");

        }
    }
}
