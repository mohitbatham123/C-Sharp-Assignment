using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class powerof2
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value");
            int a = Convert.ToInt32(Console.ReadLine());

            int b = a & (a - 1);   // using bitwise method to find out the power of 2
            if (b == 0)
            {
                Console.WriteLine("The number is power of 2");
            }
            else
            {
                Console.WriteLine("the number is not power of 2");
            }
        }
    }
}
