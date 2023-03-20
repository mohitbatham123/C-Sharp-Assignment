internal class Program
{
    public const int full_time = 1;
    public const int PART_time = 2;
    private static void Main(string[] args)
    {
        // check employee wage within a 20 working days collection

        int Emp_rate_hour = 20, Emphrs = 0, Employeewage = 0, Day, Totalemployeewage = 0, Totalworkingdays = 0, Total_working_hour =0;    // Defining the varialbles we use in this code 
        for(Day=1;Day<=20;Day++)                      // we apply for loop  to execuate until condition is false 
        {
            Random random = new Random();             // Random they give the number randomly
            int Check_employee_working = random.Next(0, 2);      

            // we use switch case when employee working part time and full time 
            switch(Check_employee_working)
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
            Total_working_hour = (Total_working_hour + Emphrs);
            Totalemployeewage += Employeewage;                     // total emplyee wage stored in a variable total employeewage
            Console.WriteLine("Employee wage :" + Employeewage);  // they display out the employeewage in 20 working days    
                   
        }
        Console.WriteLine("---------------------------------------------------------");
        Console.WriteLine("Employee total working hour" + Total_working_hour);
        Console.WriteLine("Total employee wage = " + Totalemployeewage); // they display out the totalemployeewage
        



    }
}