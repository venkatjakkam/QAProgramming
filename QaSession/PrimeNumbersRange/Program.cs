using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbersRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, count = 0, i,number;
            Console.WriteLine("Enter starting number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Ending number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Prime numbers between {0} and {1} are:", n1, n2);

            for(number= n1;number<= n2;number++)
            {
                count = 0;

                for(i=2;i<=number/2;i++)
                {
                    if(number%i==0)
                    {
                        count++;
                        break;
                    }
                }

                if (count == 0 && number != 1)
                {
                    Console.Write("{0}", number);
                }
                Console.Write("\n");
                
            }
            Console.ReadLine();
            
            
        }
    }
}
