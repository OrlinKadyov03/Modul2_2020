using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3zad
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int>  mini = new Dictionary<string, int>();

            while (true)
            {
                string rudi = Console.ReadLine();
                if (rudi=="stop")
                {
                    break;
                }
                int kolichestvo = int.Parse(Console.ReadLine());
                if (mini.ContainsKey(rudi))
                {
                    mini[rudi]=kolichestvo++;
                }
                else
                {
                    mini.Add(rudi,kolichestvo);
                }
                foreach (var item in mini)
                {
                    Console.WriteLine($"{item.Key}{item.Value}");
                }

            }
            
        }
    }
}
