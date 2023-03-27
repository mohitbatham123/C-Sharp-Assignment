using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoyeeManagement
{
    public class UC9_compute_emp_wage_save_com
    {
        
        private string company;
        private int empRatePerhrs;
        private int numOworkingDays;
        private int maxHoursPermonth;
        private int totalEmpwage;

        public  UC9_compute_emp_wage_save_com(string company, int empRatePerhrs, int numOworkingDays, int maxHoursPermonth)
        {
            this.company = company;
            this.empRatePerhrs = empRatePerhrs;
            this.numOworkingDays = numOworkingDays;
            this.maxHoursPermonth = maxHoursPermonth;
        }
        public void computewage()
        {
            const int full_time = 1;
            const int PART_time = 2;
            int emphrs = 0, totalEmphrs = 0, totalWorkingDays = 0;
            while (totalEmphrs <= maxHoursPermonth || totalWorkingDays < numOworkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empcheck = random.Next(0, 3);
                switch (empcheck)
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
                Console.WriteLine("Days" +" "+ totalWorkingDays +" "+ "Emphrs" + emphrs);
            }
            totalEmpwage = totalEmphrs * empRatePerhrs;
            
            
        }
        public string toString()
        {
            return "Total employee wage for company" +" "+ this.company + " " + this.totalEmpwage;
        }
    }
}
