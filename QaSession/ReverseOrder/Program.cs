using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseOrder
{
    class Program
    {
        static void Main(string[] args)
        {
            char l1, l2, l3;
            Console.WriteLine("Enter a letter:");
            l1 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a letter:");
            l2 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter a letter:");
            l3 = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("{0}{1}{2}",l3,l2,l1);
            Console.ReadLine();
        }
    }
}
