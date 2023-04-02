using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class even_or_odd_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = a % 2;
            if (b == 0)
            {
                Console.WriteLine("This is a even number");
            }
            else
            {
                Console.WriteLine("This is a odd number");
            }
        }
    }
}
