using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swaping
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2;
            Console.WriteLine("Enter first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            num2 = int.Parse(Console.ReadLine());
            num1 = num1 + num2;
            num2 = num1 - num2;
            num1 = num1 - num2;
            Console.WriteLine("After swap:");
            Console.WriteLine("First Number:" + num1);
            Console.WriteLine("Second Number:" + num2);
            Console.ReadLine();

        }
    }
}
