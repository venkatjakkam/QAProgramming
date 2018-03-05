using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GreatestElementP8
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, num3, max, min;
            Console.WriteLine("Enter First Element:\n");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Element:\n");
            num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter First Element:\n");
            num3 = int.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                max = num1;
                min = num2;
            }
            else
            {
                max = num2;
                min = num1;
            }
            if (num3 > max)
            {
                max = num3;
            }
            if (num3 < min)
            {
                min = num3;
            }
            Console.WriteLine("Largest number is:" + max);
            Console.WriteLine("Lowest number is:" + min);
            Console.ReadLine();
        }
    }
}
