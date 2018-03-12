using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Febonacci_SeriesP37
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0, b = 1, c = 0;
            int number;
            Console.WriteLine("Enter a number for Febonacci series limit:");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Febonacci are:{0}", a);
            Console.WriteLine("Febonacci are:{0}", b);
            for (int i=0;i<number-2;i++)
            {  
                c = a + b;
                Console.WriteLine("Febonacci are:{0}",c);
                a = b;
                b = c;
            }
            Console.ReadLine();
        }
    }
}
