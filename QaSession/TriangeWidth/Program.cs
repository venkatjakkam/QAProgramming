
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Hello_Word
{
    class Program
    {
        static void Main(string[] args)
        {
            int val, width;
            int i, j, k;
            Console.WriteLine("Enter a number:");
            val = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter a width :");
            width = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= width; i++)
            {
                for (j = 1; j <= width - i; j++)
                {
                    Console.Write("");
                }
                for (k = 1; k <= j; k++)
                {
                    Console.Write(val);
                }
                Console.WriteLine("");
            }
            Console.ReadLine();
        }
    }
}