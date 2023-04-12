//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace first_riview_practice
//{
//    internal class days_month_years
//    {
//        public static void Main(string[] args)
//        {
//            Console.Write("Please Enter month : ");
//            int m = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Please Enter day : ");
//            int d = Convert.ToInt32(Console.ReadLine());
//            Console.Write("Please Enter year : ");
//            int y = Convert.ToInt32(Console.ReadLine());

            
//            int y0 = y - (14 - m) / 12;
//            Console.WriteLine("y0 : " + y0);

            
//            int x = y0 + (y0 / 4) - (y0 / 100) + (y0 / 400);
//            Console.WriteLine("x : " + x);
//            int m0 = m + 12 * ((14 - m) / 12) - 2;
//            Console.WriteLine("m0 : " + m0);
//            int d0 = (d + x + 31 * m0 / 12) % 2;
//            Console.WriteLine("d0 : " + d0);

//            string[] days = { "Sunday", "Monday", " Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };

        
//            Console.WriteLine("Day of the Week : " + days[d0]);

//        }
//    }
//}
