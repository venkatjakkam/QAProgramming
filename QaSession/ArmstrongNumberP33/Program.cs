using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArmstrongNumberP33
{
    class Program
    {
        static void Main(string[] args)
        {
            int num, sum = 0, remainder;
            Console.WriteLine("Enter a number for find armstrong or not:");
            num = Convert.ToInt32(Console.ReadLine());

            
            for (int i = num; i > 0; i = i / 10)
            {
                remainder = i % 10;
                sum = sum + (remainder * remainder * remainder);
            }
            Console.WriteLine("sum of digits of a number:" + sum);
            if(num==sum)
            {
                Console.WriteLine(num+" is armstrong number");
            }
            else
            {
                Console.WriteLine(num + "is not armstrong number");
            }
            Console.ReadLine();
        }
    }
}
