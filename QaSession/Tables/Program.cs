using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tables
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.WriteLine("Enter a number:");
            num = int.Parse(Console.ReadLine());
            Console.Write("\n");
            for (i = 1; i <= 10; i++)
            {
                Console.Write("{0} X {1} = {2} \n", num, i, num * i);
            }
            Console.ReadLine();
        }
    }
}
