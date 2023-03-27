using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoyeeManagement
{
    internal class UC8_mployee_wage_multiple_company
    {
        public static int computewage(string company,int empRatePerhrs,int numOworkingDays,int maxHoursPermonth)
        {
            const int full_time = 1;
            const int PART_time = 2;
            int emphrs = 0, totalEmphrs = 0, totalWorkingDays = 0;
            while(totalEmphrs<= maxHoursPermonth || totalWorkingDays<numOworkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch(empcheck)
                {
                    case full_time:
                        emphrs = 8;
                        break;
                    case PART_time:
                        emphrs = 4;
                        break;
                    default:
                        emphrs = 0;
                        break;
                }
                totalEmphrs += emphrs;
                Console.WriteLine("Days"+ totalWorkingDays + "Emphrs" +emphrs);
            }
            int totalEmpwage = totalEmphrs * empRatePerhrs;
            Console.WriteLine("Total emp wage for company:" +" "+ company + " " +"is" + totalEmpwage);
            return totalEmpwage;
        }
        
    }
}
