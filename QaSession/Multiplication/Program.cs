using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, result;
            Console.WriteLine("Enter first value to multiply:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number to multiply:");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third number to multiply:");
            num3 = int.Parse(Console.ReadLine());
            result = num1 * num2 * num3;
            Console.WriteLine(num1 + "*" + num2 + "*" + num3 + "=" + result);
            Console.ReadLine();

        }
    }
}
