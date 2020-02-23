using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace МногомеренМасив
{
    class Program
    {
        static void Main(string[] args)
        {
            //Деклариране на двумерен масив
            int[,] a = new int[2, 3];
            int[,] b = { { 1, 2, 3 }, { 4, 5, 6 }, };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j <3 ; j++)
                {
                    Console.Write($" a=[{i},{j}]=");
                    a[i, j] = int.Parse(Console.ReadLine());
                }
            }
            //Печат масив
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"a=[{i},{j}]={a[i,j]}");
                }
                

                double sum = 0;
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine(a[i,j]+" ");
                    sum += a[i, j];
                }
                double avg = sum / 3;

                Console.WriteLine($"ave={avg}");
            }

            int brRed = a.GetLength(0);
            Console.WriteLine($"brRed={brRed}");

            int brKol = a.GetLength(1);
            Console.WriteLine($"brKol={brKol}");
        }
    }
}
