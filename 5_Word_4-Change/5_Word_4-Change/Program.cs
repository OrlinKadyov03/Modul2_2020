using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Word_4_Change
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = a;
            Console.WriteLine("before");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");
            a = b;
            b = c;
            c = a;
            Console.WriteLine("after");
            Console.WriteLine($"a={a}");
            Console.WriteLine($"b={b}");


        }
    }
}
