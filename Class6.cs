using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmoyeeManagement
{
    internal class Class6
    {
        public static void Employeewhileloop()
        {
            const int full_time = 1;
            const int PART_time = 2;
            const int Num_of_working_days = 20;
            const int Max_hrs_in_month = 100;
            int Emp_rate_hour = 20, Emphrs = 0, Employeewage = 0, totalemphrs = 0, Totalemployeewage = 0;   // Defining the varialbles we use in this code 
            int total_workingdays = 0;
            while (total_workingdays <= Max_hrs_in_month || total_workingdays < Num_of_working_days)                      // we apply for loop  to execuate until condition is false 
            {
                total_workingdays++;
                Random random = new Random();             // Random they give the number randomly
                int Check_employee_working = random.Next(0, 3);

                // we use switch case when employee working part time and full time 
                switch (Check_employee_working)
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
                Employeewage = Emphrs * Emp_rate_hour;                  // calculate the employeee wage 
                Totalemployeewage += Employeewage;
                totalemphrs += Emphrs;
                                                                   // total emplyee wage stored in a variable total employeewage
                Console.WriteLine("Employee wage :" + Employeewage);  // they display out the employeewage in 20 working days    

            }
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Employee total working hour" + totalemphrs);
            Console.WriteLine("Total employee wage = " + Totalemployeewage); // they display out the totalemployeewage
        }
    }
}
