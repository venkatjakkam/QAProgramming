using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofdigitsP6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, sum = 0;
            Console.WriteLine("Enter the num to find sum of integers:");
            n = int.Parse(Console.ReadLine());
            while (n > 0)
            {
                r = n % 10;
                sum = sum + r;
                n = n / 10;
            }
            Console.WriteLine("Sum of digits of given integers is:" + sum);
            Console.ReadLine();
        }
    }
}
