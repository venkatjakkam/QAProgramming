using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PalindromeP39
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, reverse=0, remainder,original;
            Console.WriteLine("Enter a number to check palindrome or not:");
            n = Convert.ToInt32(Console.ReadLine());
            original = n;
            while (n>0)
            {
                remainder = n % 10;
                reverse = (reverse * 10) + remainder;
                n = n / 10;
            }
            if(original == reverse)
            {
                Console.WriteLine(original + " is a palindrome");
            }
            else
            {
                Console.WriteLine(original + " is not a palindrome");
            }
            Console.ReadLine();
        }
    }
}
