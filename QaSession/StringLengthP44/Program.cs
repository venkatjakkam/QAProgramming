using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringLengthP44
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = " ";
            int length = 0;

            Console.WriteLine("Enter a String to find lenth:");
            str = Console.ReadLine();
            foreach(char ch in str)
            {
                length++;
            }
            Console.WriteLine("Length is:" + length);
            Console.ReadLine();

        }
    }
}
