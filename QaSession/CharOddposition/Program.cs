using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreateNewStringP9
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = "CAMPSYSTEMS";

            string str1 = " ";
            int i;
            Console.WriteLine("Input a string: ");

            string str = Console.ReadLine();




            for (i = 0; i < str.Length; i += 2)
            {
                // Console.Write(str[i]);
                str1 = str1 + str[i];
            }

            Console.WriteLine("New string is :" + str1);
            Console.ReadLine();
        }
    }
}
