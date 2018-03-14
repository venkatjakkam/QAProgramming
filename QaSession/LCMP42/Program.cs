using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCMP42
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, j, hcf = 1, lcm, n1, n2;
            Console.WriteLine("Enter 1st number for LCM is:");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter 2nd number for LCM is:");
            n2 = Convert.ToInt32(Console.ReadLine());
            j = (n1 < n2) ? n1 : n2;
            for(i=1;i<= j;i++)
            {
                if(n1%i==0&&n2%i==0)
                {
                    hcf = i;
                }
            }

            lcm = (n1 * n2) / hcf;
            Console.WriteLine("LCM of {0} and {1} is:{2}", n1, n2, lcm);
            Console.ReadLine();
        }
    }
}
