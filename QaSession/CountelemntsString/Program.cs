using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountelemntsString
{
    class Program
    {
        static void Main(string[] args)
        {
            String str = " ";
            int i;
            int alphabetscount = 0, numbercount = 0, specialcharcount = 0;
            Console.WriteLine("Enter  a string to find alphabets,numbers and sepecial characters");
            str = Console.ReadLine();
            for(i=0;i<str.Length;i++)
            {
                if((str[i]>='a'&&str[i]<='z')||(str[i]>='A'&&str[i]<='Z'))
                {
                    alphabetscount++;
                }
                else if(str[i]>='0'&&str[i]<='9')
                {
                    numbercount++;
                }
                else
                {
                    specialcharcount++;
                }
            }
            Console.WriteLine("Number of alphabets in the string:   " + alphabetscount);
            Console.WriteLine("Number of digits in the string:   " + numbercount);
            Console.WriteLine("Number of Special characters in the string:   " + specialcharcount);
            Console.ReadLine();
        }
    }
}
