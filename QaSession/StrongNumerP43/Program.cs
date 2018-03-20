using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrongNumerP43
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, i, fact, sum = 0, remainder, originalNumber ;

            Console.WriteLine("Enter a number:");
            number = Convert.ToInt32(Console.ReadLine());
            originalNumber = number;
            while (number>0)
            {
                
                remainder = number % 10;
                //fact = factorial();
                fact = remainder;
                for(i=remainder-1;i>=1;i--)
                {
                    fact = fact * i;
                }
                sum = sum + fact;
                number = number / 10;


            }
            if(originalNumber == sum)
            {
                Console.WriteLine("Given number " + originalNumber + "  is Strong Number");
            }
            else
            {
                Console.WriteLine("Given number  " + originalNumber + "  is not a Strong Number");
            }
           
            //Console.WriteLine("Factorial of given number is:" + sum);
            Console.ReadLine();
        }

        //static int factorial()
        //{

        //}
    }
}
