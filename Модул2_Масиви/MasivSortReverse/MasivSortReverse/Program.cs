using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasivSortReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = { 2, 5, 8, 4, 9, 2,32,21,12 };

            int sum = a.Sum();
            Console.WriteLine(sum);

            //sortirane na masiv
            Array.Sort(a);
            Console.WriteLine(string.Join(" ", a));
            foreach (var item in a)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            for (int i = 0; i < a.Length; i++)
            {
                Console.Write(a[i]+ " ");
            }
            //obrushtane na masiv
            Console.WriteLine();
            Array.Reverse(a);
            Console.Write(string.Join("/",a));


        }
    }
}
