using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddnumbersP5
{
    class Program
    {
        static void Main(string[] args)
        {
            int i;
            Console.WriteLine("Odd numbers from 1 to 99");
            for (i = 1; i <= 100; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                    Console.Write("\n");
                }
            }
            Console.ReadLine();
        }
    }
}
