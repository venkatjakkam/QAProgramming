using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PerfectNumberP32
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n, number,sum = 0;
            Console.WriteLine("enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            n = number;
            for(i=1;i< n;i++)
            {
                if(number%i==0)
                {
                    Console.Write("\nPositive Divisors are:{0}", i);
                    sum = sum + i;
                }
                 
            }
            Console.WriteLine("\nThe sum of divisor is:" + sum);
            if (sum == n)
            {
                Console.WriteLine("So, the number is perfect");
            }
            else
            {
                Console.WriteLine("So, the number is not perfect");
            }
             Console.ReadLine();
        }
    }
}
