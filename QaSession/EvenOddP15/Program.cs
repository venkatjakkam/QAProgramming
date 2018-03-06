using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenOddP15
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Boolean check = true;
            Boolean check1 = false;
            Console.WriteLine("First Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("First Number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0 && b % 2 == 0)
            {
                Console.WriteLine("Expected output:"+check);
            }
            else if (a % 2 != 0 && b % 2 != 0)
            {
                Console.WriteLine("Expected output:" + check);
            }
            else
                Console.WriteLine("Expected output:" + check1);
            Console.ReadLine();
        }
    }
}
