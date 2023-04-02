using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class find_the_largest_three_number
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the 1st number");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd nymber");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 3rd nymber");
            int c = Convert.ToInt32(Console.ReadLine());
            if (a > b)
            {
                if (a > c)
                {
                    Console.Write("The 1st Number is the greatest among three.");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. ");
                }
            }
            else if (b > c)
                Console.Write("The 2nd Number is the greatest among three ");
            else
                Console.Write("The 3rd Number is the greatest among three ");
        }
    }
}
