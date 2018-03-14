using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Divisibleby9P40
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, sum = 0;
            Console.WriteLine("Integers Divisible by 9 are:");
            for (i=100;i<=200;i++)
            {
                if(i%9==0)
                {
                    Console.Write(" "+i);
                    sum = sum + i;
                }
            }
            Console.WriteLine("\nThe sum:"+sum);
            Console.ReadLine();
        }
    }
}
