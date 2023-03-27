namespace EmoyeeManagement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            UC9_compute_emp_wage_save_com Dmart = new UC9_compute_emp_wage_save_com("Dmart", 20, 10, 10);
            UC9_compute_emp_wage_save_com Relince = new UC9_compute_emp_wage_save_com("Relince", 24, 10, 14);
            Dmart.computewage();
            Console.WriteLine(Dmart.toString());
            Console.WriteLine( "-----------------------------");
            Relince.computewage();
            Console.WriteLine(Relince.toString());
        }
    }
}