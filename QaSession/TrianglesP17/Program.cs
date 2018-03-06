using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrianglesP17
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.WriteLine("Test Data:");
            a = Convert.ToInt32(Console.Read());
            b = Convert.ToInt32(Console.Read());
            c = Convert.ToInt32(Console.Read());
            Console.ReadLine();
            Console.WriteLine("Expected output:");
            if(a == b&&a==c&&b==c)
            {
                Console.WriteLine("Equilateral ");
            }
            else if(a != b && b != c&&a!=c)
             {
                Console.WriteLine("Scalene");
            }
            else
            {
                Console.WriteLine("Isosecles");
            }

            Console.ReadLine();
        }
    }
}
