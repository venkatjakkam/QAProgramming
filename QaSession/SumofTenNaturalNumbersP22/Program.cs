using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofTenNaturalNumbersP22
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int i,sum = 0;
            Console.Write("\nFirst 10 natural numbers:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine("Sum of natural numbers:");
            for (int i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
                Console.WriteLine
            }

        }
    }
}
