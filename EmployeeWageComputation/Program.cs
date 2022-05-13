using System;

namespace EmployeeWageComputation
{
    class Program
    {
        static void Main(string[] arg)
        {
            int choice;
            do
            {
                Console.WriteLine("\nWelcome to Employee Wage Computation Program");
                Console.WriteLine("\nEnter the choice");
                Console.WriteLine("1. Check Employee is present is OR Absent");
                Console.WriteLine("2. Calculate daily Employee Wages");
                Console.WriteLine("3. Part time Employee and Wages");
                Console.WriteLine("0: Exit");
                choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        EmpPresentAbsent empPresentAbsent = new EmpPresentAbsent();
                        empPresentAbsent.PresentAbsent();
                        break;
                    case 2:
                        DailyEmpWage dailyEmpWage = new DailyEmpWage();
                        dailyEmpWage.DailyWages();
                        break;
                    case 3:
                        PartTimeEmp partTimeEmp = new PartTimeEmp();
                        partTimeEmp.Parttime();
                        break;
                }
            }while(choice != 0);
        }
    }
}
