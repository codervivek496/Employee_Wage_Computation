using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] arg)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program");
            EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
            empPresentAbsent.PresentAbsent(); 
        }
    }
}
