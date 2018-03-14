using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HCFP41
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, n1, n2, j, hcf = 1;
            Console.WriteLine("input 1st number:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("input 2nd number:");
            n2 = Convert.ToInt32(Console.ReadLine());
            j = (n1 < n2) ? n1: n2;
            for(i=1;i<= j;i++)
            {
                if(n1%i==0&&n2%i==0)
                {
                    hcf = i;
                }
            }
            Console.WriteLine("HCF of {0} and {1} is: {2}", n1, n2, hcf);
            Console.ReadLine();
        }
    }
}
