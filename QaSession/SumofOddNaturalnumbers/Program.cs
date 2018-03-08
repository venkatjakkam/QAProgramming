using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofOddNaturalnumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            int sum = 0;
            Console.WriteLine("Input Number of terms: ");
            n = Convert.ToInt32(Console.ReadLine());
            for(i=1;i< (2*n);i+=2)
            {
                Console.WriteLine("Odd numbers are:" + i);
                sum = sum + i;
            }
            
            Console.WriteLine("Sum of first" + n + "Numbers is:" + sum);
            Console.ReadLine();
        }
        
    }
}
