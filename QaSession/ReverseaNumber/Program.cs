using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseaNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse = 0,remainder;
            Console.WriteLine("Enter a number to reverse:");
            n = Convert.ToInt32(Console.ReadLine());
            while(n>0)
            {
                remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n = n / 10;
            }

            Console.WriteLine("Reverse of given number is:" + reverse);
            Console.ReadLine();
        }
    }
}
