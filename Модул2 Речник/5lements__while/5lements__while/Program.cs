using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5lements__while
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> market = new  Dictionary<string, double>();
            while (true)
            {
                Console.Write("stoka:");
                double s = 0;
                string stoka = Console.ReadLine();
                if (stoka =="stop")
                {
                    break;
                }

                Console.WriteLine("Cena");
                int price = int.Parse(Console.ReadLine());

                market.Add(stoka, price);
            }
            Console.WriteLine("==========");
            foreach (var item in market)
            {
                Console.WriteLine($"stoka:{item.Key}:cena{item.Value}lv");
                 s += item.Value;
            }
            Console.WriteLine(s);
        }
    }
}
