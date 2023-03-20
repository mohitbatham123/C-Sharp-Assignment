internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Check employee is present or not");  
        int employee = 1;                                  // define the variable
        Random random = new Random();                      // Random they give the number randomly
        int checkemployee = random.Next(0, 2);
        if (employee == checkemployee)                   // we apply the ifelse statement condtion true then print the Employee is present 
        {                                                // condition is false then print the Employee is absent
            Console.WriteLine("Employee is present");
        }
        else
        {
            Console.WriteLine("Employee is absent");
        }
    }
}