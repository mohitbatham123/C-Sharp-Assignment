using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoyeeManagement
{
    internal class Class3
    {
        public static void Employeewithpart()
        {
            int Isfulltime = 1, emp_rate_hour = 20, emphrs = 0, employe_part_time = 2, employeewage = 0;

            Random random = new Random();        // Random they give the number randomly
            int emcheck = random.Next(1, 3);
            if (emcheck == Isfulltime)      // we apply ifelse condition  employee is present full time
            {
                emphrs = 8;
            }
            else if (employe_part_time == emcheck)   // we apply else if condition employee is part time
            {
                emphrs = 4;
            }
            else                       // by defaulte else is shows employee is absentm and 
            {
                emphrs = 0;
            }
            employeewage = emphrs * emp_rate_hour;     // calculate employee wage
            Console.WriteLine("Empwage :" + employeewage);    // display the employee wage
        }
    }
}
