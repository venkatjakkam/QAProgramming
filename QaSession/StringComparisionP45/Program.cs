using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringComparisionP45
{
    class Program
    {
        static void Main(string[] args)
        {
            String str1 = " ";
            String str2 = " ";
            int length1 = 0, length2 = 0 ;
            Boolean status = true;
            Console.WriteLine("Enter first string:");
            str1 = Console.ReadLine();
            Console.WriteLine("Enter second string:");
            str2 = Console.ReadLine();
            foreach(char ch in str1)
            {
                length1++;
            }
            Console.WriteLine("Length of first string:" + length1);
            foreach(char ch1 in str2)
            {
                length2++;
            }
            Console.WriteLine("Length of second string:" + length2);
            if(length1==length2)
            {
                for (int i = 0; i < length1; i++)
                {
                    if(str1[i]==str2[i])
                    {
                        //Console.WriteLine("string lengths are equal and strings are  equal");
                        status = true;
                        
                    }
                    else
                    {
                        // Console.WriteLine("string legths are equal and strings are not equal.");
                        status = false;
                    }

                }
                if(status == true)
                {
                    Console.WriteLine("string lengths are equal and strings are  equal");
                }
                else
                {
                    Console.WriteLine("string legths are equal and strings are not equal.");
                }
               // Console.WriteLine("Both strings lengths are equal");
            }
            else
            {
                Console.WriteLine("Lengths are not equal");
            }

            Console.ReadLine();
        }
    }
}
