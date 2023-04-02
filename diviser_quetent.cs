using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class diviser_quetent
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter the Dividend number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Divisor nymber");
            int b = Convert.ToInt32(Console.ReadLine());

            int quotient = a / b;
            int remainder = a % b;

            Console.WriteLine("Dividend"+ a + "Divisor" + b);
            Console.WriteLine("Quotient = " + quotient);
            Console.WriteLine("Remainder = " + remainder);
            Console.ReadLine();
        }
    }
}
