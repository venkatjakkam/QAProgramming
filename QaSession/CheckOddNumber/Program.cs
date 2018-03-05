using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckOddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 2, 4, 7, 8, 6 };
            int i;
            Boolean check = true;
            Console.Write("\nElements in the array:");
            for (i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            for (i=0;i<arr.Length;i++)
            {
                if(check = arr[i]%2!=0)
                {
                    Console.WriteLine("\nCheck if an array contains an odd number?" + check);
                }
                
            }


            Console.ReadLine();
        }
    }
}
