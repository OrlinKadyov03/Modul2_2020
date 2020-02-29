using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddElements_Na_edin_red
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> market = new Dictionary<string, int>();
            var linia = Console.ReadLine().Split();

            while (true)
            {
                string st = linia[0];
                if (st == "stop")
                {
                    break;
                }
                int price = int.Parse(linia[1]);
                if (market.ContainsKey(st))
                {
                    market[st] = market[st] + price;
                }
                else
                {
                    market.Add(st, price);
                }

                                          
                   
                linia = Console.ReadLine().Split();

            }

            foreach (var item in market)
            {
                Console.WriteLine($"{item.Key} =>{item.Value}leva");
            }
        }
    }
}
