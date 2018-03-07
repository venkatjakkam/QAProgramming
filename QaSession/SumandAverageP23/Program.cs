using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumandAverageP23
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[10];
            int i, sum = 0;
            float avg;
            Console.WriteLine("Input 10 Numbers:");
            for(i=0;i<num.Length;i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
                Console.Write("\n");
            }

            for (i = 0; i < num.Length; i++)
            {
                Console.WriteLine("Number-"+(i+1)+":" +  num[i]);
            }
            for (i=0;i<num.Length;i++)
            {
                sum = sum + num[i];
            }
             avg = (float)sum / 10;

            Console.WriteLine("The sum of 10 no is:" + sum);
            Console.WriteLine("The average of 10 no is:" + avg);
            Console.ReadLine();
        }
    }
}
