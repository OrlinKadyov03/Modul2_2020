using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stoprechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> person = new Dictionary<string, int>
            {
                {"Anyn",2112},
                {"Anyn ",222},
                {"to ",221},
                {"molo ",225},
                {"Anyn to molo ",122},
            };
            foreach (var item in person)
   
            {
                Console.WriteLine($"{item.Key}:{item.Value}");
            }
            var sortperson = person.OrderBy(x => x.Key);
            Console.WriteLine("=====");
            foreach (var item in sortperson)
            {
                Console.WriteLine($"{item.Key}:{item.Value} age");
            }
            Console.WriteLine("===SortAgeByDes==");
            var sortAgeDes = person.OrderByDescending(x=> x.Value);
            foreach (var item in sortperson)
            {
                Console.WriteLine($"{item.Key}:{item.Value} age");
            }



        }
    }
}
