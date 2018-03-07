using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VowelOrConsonant
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Alphabet:");
            char ch;
            ch = Convert.ToChar(Console.ReadLine().ToLower());

            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The alphabet is a Vowel.");
                    break;
                case 'e':
                    Console.WriteLine("The alphabet is a Vowel.");
                    break;
                case 'i':
                    Console.WriteLine("The alphabet is a Vowel.");
                    break;
                case 'o':
                    Console.WriteLine("The alphabet is a Vowel.");
                    break;
                case 'u':
                    Console.WriteLine("The alphabet is a Vowel.");
                    break;
                default:
                    Console.WriteLine("The alphabet is a consonant.");
                    break;
            }

            Console.ReadLine();

        }
    }
}
