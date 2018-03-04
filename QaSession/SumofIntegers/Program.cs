using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, sum, mul;
            Console.WriteLine("Enter first number:");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second number:");
            num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                mul = 3 * (num1 + num2);
                Console.WriteLine("Expected output:" + mul);
                Console.ReadLine();
            }
            else
            {
                sum = num1 + num2;
                Console.WriteLine("Expected output:" + sum);
                Console.ReadLine();
            }
        }
    }
}
