using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperationswithNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            char ch;
            
            Console.WriteLine("Enter First Number:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Operand:");
            ch = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("Enter Second Number:");
            b = Convert.ToInt32(Console.ReadLine());
            if (ch == '+')
            {
                Console.WriteLine("Expected output:" + (a+b));
            } else if (ch == '-')
            {
                Console.WriteLine("Expected output:" + (a - b));
            }
            else if (ch == '*')
            {
                Console.WriteLine("Expected output:" + (a * b));
            }
            else if (ch == '/')
            {
                if (b == 0)
                {
                    Console.WriteLine("Not a valid number for division please enter second number other than zero");

                    Console.WriteLine("Enter Second Number:");
                    b = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Expected output:" + (a / b));
                }
                else {
                    Console.WriteLine("Expected output:" + (a / b));
                }
            }



            Console.ReadLine();

        }
    }
}
