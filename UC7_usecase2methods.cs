using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoyeeManagement
{
    internal class usecase2methods
    {
        const int full_time = 1;
        const int PART_time = 2;
        const int Num_of_working_days = 20;
        const int Max_hrs_in_month = 100;
        const int Emp_rate_hour = 20;
        static int totalemphrs = 0;
        static int emphr = 0;
        static int total_workingdays = 0;
        public static int getworkinghour(int rand)
        {
            int Emphrs = 0;
            switch (rand)
            {
                case full_time:                       // case 1 they shows employee working full time present
                    Emphrs = 8;
                    break;
                case PART_time:                      // case 2 they shows employee working part time present
                    Emphrs = 4;
                    break;
                default:                    // in case of default they represent employee is absent
                    Emphrs = 0;
                    break;
            }
            return Emphrs;
             
        }
        public static void computeemployeewage()
        {
            int monthlysalary = 0;
            while (total_workingdays <= Max_hrs_in_month || total_workingdays < Num_of_working_days)
            {
                total_workingdays++;
                Random random = new Random();             // Random they give the number randomly
                int rand = random.Next(0, 3);
                emphr = getworkinghour(rand);    // this line  we calling first method
                totalemphrs += emphr;
            }
            monthlysalary = Emp_rate_hour * totalemphrs;
            Console.WriteLine("total employee salary in a month"+ monthlysalary);


        }
    }
}
