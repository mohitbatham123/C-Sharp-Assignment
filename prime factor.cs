//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace assingment_6
//{
//    internal class prime_factor
//    {
//        static void Main(string[] args)
//        {
//            Console.WriteLine("Enter the number chech if its prime or not :");
//            int num = int.Parse(Console.ReadLine());
//            if (num <= 1)
//            {
//                Console.WriteLine("you Enter the Invailed number");
//            }
//            else
//            {
//                int flag = 0;
//                for (int i = 2; i < num; i++)
//                {
//                    if (num % i == 0)
//                    {
//                        Console.WriteLine("{0} is not prime");
//                        flag = 1;
//                        break;
//                    }
//                }
//                if (flag == 0)
//                {
//                    Console.WriteLine("{0} is prime");
//                }
//            }
//        }
//    }

//}

