using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicSeriesandsum
{
    class Program
    {
        static void Main(string[] args)
        {
            int i,n;
            double s = 0.0;
            Console.WriteLine("Enter a number:");
            n = Convert.ToInt32(Console.ReadLine());
            for(i = 1;i< n;i++)
            {
                Console.WriteLine("1/{0}+", i);
                s = s + 1 / (float)i;
            }
            Console.WriteLine("\nSum of Series upto {0} terms :{1} \n",n, s);
            Console.ReadLine();
        }
    }
}
