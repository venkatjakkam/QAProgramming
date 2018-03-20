using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrangleAngles
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            int d = 0;
            Console.WriteLine("Enter First angle:");
            a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second angle:");
            b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Third angle:");
            c = Convert.ToInt32(Console.ReadLine());
            d = a + b + c;
            if(d==180)
            {
                Console.WriteLine("This trangle is valid..");
            }
            else
            {
                Console.WriteLine("This trangle is not valid..");
            }
            Console.ReadLine();
        }
    }
}
