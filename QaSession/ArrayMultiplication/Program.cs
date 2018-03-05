using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayMultiplicationP7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 12, 10, 3, 4 };
            int[] arr1 = { 2, 3, 4, -5 };
            Console.Write("\nElements in First array:");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.Write("\nElements in second array:");
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write(arr1[i] + " ");
            }
            Console.WriteLine("\n Multiply corresponding elements of two arrays: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] * arr1[i] + " ");
            }
            Console.Write("\n");
            Console.ReadLine();

        }
    }
}
