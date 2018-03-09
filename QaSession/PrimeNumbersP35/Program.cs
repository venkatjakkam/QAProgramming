using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersP35
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, count = 0;
            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            for(i=1;i<=number;i++)
            {
                if(number%i==0)
                {
                    count = count + 1;
                }
                
            }
            if(count==2)
            {
                Console.WriteLine("\n" + number + " is a Prime number");
            }
            else
            {
                Console.WriteLine("\n" + number + " is not a Prime number");
            }
            //Console.WriteLine("Count is:" + count);
            Console.ReadLine();
        }
    }
}
