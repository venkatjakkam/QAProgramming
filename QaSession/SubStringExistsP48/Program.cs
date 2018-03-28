using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubStringExistsP48
{
    class Program
    {
        public void substing()
        {
            Console.WriteLine("Input a String: ");
            string str = Console.ReadLine();
            Console.WriteLine("Input a string search:");
            string substr = Console.ReadLine();
            string matchstr = string.Empty;
           // bool contains = false;

            for(int i=0;i<str.Length;i++)
            {
               // matchstr = matchstr+str[i];
               for(int j= i;j<i+substr.Length;j++)
                {
                    if(j<str.Length)
                    {
                        matchstr = matchstr + str[j];
                    }
                    else
                    {
                        //Console.WriteLine("The substring is not present..");
                        break;
                    }
                }
                //Console.WriteLine(matchstr);
                if(matchstr==substr)
                {
                    Console.WriteLine("Given substring is present");
                    break;
                }
                else
                {
                    matchstr = string.Empty;
                    
                }
                
            }
            Console.ReadLine();

        }
        static void Main(string[] args)
        {
            var program = new Program();
            program.substing();
        }
    }
}
