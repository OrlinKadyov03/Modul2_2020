using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace СписъкВходПечат
{
    class Program
    {
        static void Main(string[] args)
        {


            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            Console.WriteLine(string.Join(" ", num));

            //suma na spisyk
            int sum = num.Sum();
            Console.WriteLine($"sum={sum}");
            //min element
            int min = num.Min();
            Console.WriteLine($"min={min}");
            //max element
            int max = num.Max();
            Console.WriteLine($"max={max}");
            //sreden 
            double avg = num.Average();
            Console.WriteLine($"avg={avg}");

            //sortirane an spisyk
            Console.WriteLine("Sortirane na spisyk ");
            num.Sort();
            Console.WriteLine(string.Join(" ",num ));
            //obryshtane na elementi 
            Console.WriteLine("Obryshtane na elemnti ");
            num.Reverse();
            Console.WriteLine(string.Join(" ",num));
            //br elemnti 
            Console.WriteLine("Br elementi");
            int brElspisyk = num.Count;
            Console.WriteLine($"brElspisyk={brElspisyk}");

            //dobavqne na element v kraq na spisyk
            Console.WriteLine("dobavqne na elementi v kraq ");
            num.Add(111);
            Console.WriteLine(string.Join(" ",num));
            //iztrivane na stoinost na konkkretna 
            Console.WriteLine("iztrivane na stoinost na konkreten indeks");
            num.Remove(6);
            Console.WriteLine(string.Join(" ",num));
            //iztrivane na stoinost s indeks 4
            Console.WriteLine("iztrivane na stoinosti s indeks ");
            num.RemoveAt(0);
            Console.WriteLine(string.Join(" ",num));
            //vmykvane na element na konkretna poziciq
            Console.WriteLine("vmykvane na element na konkretna pozici");
            num.Insert(1,222);
            Console.WriteLine(string.Join(" ",num));
        }
    }
}
