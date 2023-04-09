using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LogicalProgramming
{
    internal class Coupon
    {
        public static void Main(string[] args)
        {
            int a = 100000;
            couponCode(a);
        }
        static int value = 0;
        public static void couponCode(int a)
        {
            int j =2;
            for (int i = 1; i < j; i++)
            {
                Random random = new Random();
                int num = random.Next(a,99999999);
                Console.WriteLine("The coupon number is: " + num);
                value = num;
            }

        }
    }
}
