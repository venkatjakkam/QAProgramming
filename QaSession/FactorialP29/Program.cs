using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactorialP29
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n, fact;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            fact = n;
            for(i=n-1;i>=1;i--)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of given number is:" + fact);
            Console.ReadLine();
        }
    }
}
