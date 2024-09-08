using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Challengelabs3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Customer ID: ");
            string customerId = Console.ReadLine();

            Console.Write("Enter Customer Name: ");
            string customerName = Console.ReadLine();

            Console.Write("Enter Units Consumed: ");
            int unitsConsumed = int.Parse(Console.ReadLine());

            double billAmount = CalculateBill(unitsConsumed);

            if (billAmount > 400)
            {
                billAmount += billAmount * 0.15;
            }

            Console.WriteLine("\nElectricity Bill");
            Console.WriteLine("----------------");
            Console.WriteLine("Customer ID: " + customerId);
            Console.WriteLine("Customer Name: " + customerName);
            Console.WriteLine("Units Consumed: " + unitsConsumed);
            Console.WriteLine("Total Amount to Pay: $" + billAmount.ToString("0.00"));
        }

        public static double CalculateBill(int units)
        {
            double amount = 0;

            if (units <= 199)
            {
                amount = units * 1.20;
            }
            else if (units >= 200 && units < 400)
            {
                amount = units * 1.50;
            }
            else if (units >= 400 && units < 600)
            {
                amount = units * 1.80;
            }
            else if (units >= 600)
            {
                amount = units * 2.00;
            }

            return amount;
        }
    }


}


