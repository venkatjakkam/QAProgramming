using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofArrayIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = {1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1};
            int i, sum = 0;
            //Console.WriteLine("Enter elements in the array:");
            //for(i=0;i<arr.Length;i++)
            //{
            //    arr[i] = Convert.ToInt32(Console.ReadLine());
            //    Console.Write("\n");
            //}

            //Console.WriteLine("Elements in the array are:");
            //for (i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine("{0} ", arr[i]);
            //}
            //Console.Write("\n");
            Console.Write("\nElements in the array:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            
            for (i=0;i<arr.Length;i++)
            {
                sum = sum + arr[i];
            }

            Console.WriteLine("\nSum of elements in the array are:" + sum);
            Console.ReadLine();
        }
    }
}
