using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpacesCountinstringP50
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a string:");
            string str = Console.ReadLine();

            for(int i=0;i<str.Length;i++)
            {
                if(str[i]==' ')
                {
                    count++;
                }
                
            }
            Console.WriteLine("Spaces in the string are:" + count);
            Console.ReadLine();
        }
    }
}
