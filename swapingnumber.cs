using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assingment_5
{
    internal class swapingnumber
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter A value ");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B value to swap");
            int b = Convert.ToInt32(Console.ReadLine());
            int c = a + b;
            a = c - a;
            b = c - b;
            Console.WriteLine("A now =" + " " + a);
            Console.WriteLine("B now =" + " " + b);

        }
    }
}
