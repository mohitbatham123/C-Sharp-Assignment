using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace first_riview_practice
{
    internal class monthly_payment_income
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter principle loan amount");
            int p = int.Parse(Console.ReadLine());
            Console.WriteLine("years to pay off ");
            int Y = int.Parse(Console.ReadLine());
            Console.WriteLine("percent\r\ninterest compounded monthly");
            int R = int.Parse(Console.ReadLine());

            int n = 12 * Y;
            double r = R / (12 * 100);

            double payement = ((p * R) / (1 - Math.Pow((1 + R), -n)));
            Console.WriteLine(payement);

        }
    }
}
