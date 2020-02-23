using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_Word_3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> num = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            num.Sort();
            

            int Max = num.Max();
           

            int Min = num.Min();
            

            foreach (var item in num)
            {
                if (item==Min)
                {
                    Console.WriteLine(item + " ");
                }
            }
            foreach (var item in num)
            {
                if (item==Max)
                {
                    Console.WriteLine(item+ " ");
                }
            }
         

            


        }
    }
}
