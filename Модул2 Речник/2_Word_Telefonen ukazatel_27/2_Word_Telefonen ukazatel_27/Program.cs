using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Word_Telefonen_ukazatel_27
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> telef = new Dictionary<string, string>();
            
            while (true)
            {
                var linia = Console.ReadLine().Split();
                var command = linia[0];

                if ( command == "end")
                {
                    break;
                }
                
                if (command == "add")
                {
                    var name = linia[1];
                    var number = linia[2];
                    if (telef.ContainsKey(name))
                    {
                        telef[name] = number;
                    }
                    else
                    {
                        telef.Add(name, number);
                    }
                }

                if (command == "print")
                {
                    var name = linia[1];
                    if (telef.ContainsKey(name))
                    {

                        Console.WriteLine($"Contact{name} ->{telef[name]} ");
                    }
                    else
                    {

                        Console.WriteLine($"Contact {name} does not exist ");
                    } 
       
                }
            }
        }
    }
}
