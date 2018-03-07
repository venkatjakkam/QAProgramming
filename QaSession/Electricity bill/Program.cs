using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Electricity_bill
{
    class Program
    {
        static void Main(string[] args)
        {
            int customerid;
            string name;
            int units;
            double SurchargeAmount;
            double NetAmount = 0;


            Console.WriteLine("Enter customer id");
            customerid = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter name:");
            name = Console.ReadLine();
            Console.WriteLine("Enter Consumed units:");
            units = Convert.ToInt32(Console.ReadLine());

            if(units<100)
            {
                Console.WriteLine("Bill is not generated for below 100 units.");
            }else if(units>=100&&units<=199)
            {
                NetAmount = units * 1.20;
                Console.WriteLine("Amount Charges @Rs 1.20 per unit:" + NetAmount);
                Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
            }else if(units>=200&&units<400)
            {
                NetAmount = units * 1.50;
                Console.WriteLine("Amount Charges @Rs 1.50 per unit:" + NetAmount);
                if(NetAmount>400)
                {
                    SurchargeAmount = NetAmount * 0.15;
                    NetAmount = NetAmount + SurchargeAmount;
                    Console.WriteLine("Surcharge Amount:" + SurchargeAmount);
                    Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
                }
                else
                {
                    Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
                }
            }else if(units >= 400 && units < 600)
            {
                NetAmount = units * 1.80;
                Console.WriteLine("Amount Charges @Rs 1.80 per unit:" + NetAmount);
                if (NetAmount > 400)
                {
                    SurchargeAmount = NetAmount * 0.15;
                    NetAmount = NetAmount + SurchargeAmount;
                    Console.WriteLine("Surcharge Amount:" + SurchargeAmount);
                    Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
                }
                else
                {
                    Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
                }

            }else if(units>=600)
            {
                NetAmount = units * 2.00;
                Console.WriteLine("Amount Charges @Rs 2.00 per unit:" + NetAmount);
                if (NetAmount > 400)
                {
                    SurchargeAmount = NetAmount * 0.15;
                    NetAmount = NetAmount + SurchargeAmount;
                    Console.WriteLine("Surcharge Amount:" + SurchargeAmount);
                    Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
                }
                else
                {
                    Console.WriteLine("Net Amount paid by the customer:" + NetAmount);
                }
            }



            Console.ReadLine();

        }
    }
}
