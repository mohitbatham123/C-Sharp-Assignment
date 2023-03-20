using System.Net.Http.Headers;

namespace switchcasestatement
{
    internal class Program
    {
        public const int full_time = 1;
        public const int PART_time = 2;
        static void Main(string[] args)
        {
            // we define a varialbles 
            int emp_rate_hour = 20;    
            int emphrs = 0;
            int employeewage = 0;
            Random random = new Random();    // Random they give the number randomly
            int emcheck = random.Next(1, 3);
            switch (emcheck)                   // we apply the switch statement 
            {
                case full_time:               // In case of full time 
                    emphrs = 8;
                    break;
                case PART_time:               // In case of part time
                    emphrs = 4;
                    break;
                default:                    // by default absent
                    emphrs = 0;
                    break;
            }
            employeewage = emphrs * emp_rate_hour;    // calculate employeewage 
            Console.WriteLine("Empwage :" + employeewage);  // display the employee wage 
        }
    }
}