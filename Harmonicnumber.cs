using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class Harmonicnumber
    {
        static void Main(string[] args)
        {

            double s = 0;
            Console.Write("Input the number of terms : ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n\n");
            for (int i = 1; i <= a; i++)
            {
                Console.Write("1/{0} + ", i);
                s += 1 / (float)i;
            }
            Console.Write("\nSum of Series upto {0} terms : {1} \n", a, s);
        }
    }
}
