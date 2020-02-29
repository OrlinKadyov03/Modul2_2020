using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechnik
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            Console.WriteLine("Broi el na rechnik:");
            int brEl = int.Parse(Console.ReadLine());
            for (int i = 0; i < brEl; i++)
            {
                Console.WriteLine(" Ime:");
                string name = Console.ReadLine();
                Console.WriteLine(" n0mer:");
                string number = Console.ReadLine();


                if (phonebook.ContainsKey(name))
                {
                    phonebook[name] = number;
                }
                else
                {
                    phonebook.Add(name, number);
                }



              
            } 

            foreach (var item in phonebook)
            {
                Console.WriteLine($"ime:{item.Key} => n0mer{item.Value}");
            }
            
            phonebook.Remove( "Asen" );
            Console.WriteLine(string.Join(" ", phonebook));

            int countRe = phonebook.Count();
            Console.WriteLine($"Broy:");
        }
    }
}
