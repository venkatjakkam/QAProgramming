using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthDaysP21
{
    class Program
    {
        static void Main(string[] args)
        {
            int month;
            //int days;
            Console.WriteLine("Enter the month number:");
            month = Convert.ToInt32(Console.ReadLine());
            switch(month)
            {
                case 1:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 2:
                    Console.WriteLine("Month have 28 days");
                    break;
                case 3:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 4:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 5:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 6:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 7:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 8:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 9:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 10:
                    Console.WriteLine("Month have 31 days");
                    break;
                case 11:
                    Console.WriteLine("Month have 30 days");
                    break;
                case 12:
                    Console.WriteLine("Month have 31 days");
                    break;
                default:
                    Console.WriteLine("Please enter month between 1 to 12");
                    break;

            }

            Console.ReadLine();
        }
    }
}
