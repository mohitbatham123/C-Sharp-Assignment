using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class leapyear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the year");
            int y = Convert.ToInt32(Console.ReadLine());

            if ((y % 400) == 0)
            {
                Console.WriteLine("Is a leap year" + " " + y);
            }
            else if ((y % 100) == 0)
            {
                Console.WriteLine(" Is not a leap year" + " " + y);
            }
            else if ((y % 4) == 0)
            {
                Console.WriteLine(" Is a leap year" + " " + y);
            }
            else
            {
                Console.WriteLine(" Is not a leap year" + " " + y);
            }
        }
    }
}
