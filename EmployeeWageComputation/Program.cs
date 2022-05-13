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
                Console.WriteLine("4. Part time USing Switch statement");
                Console.WriteLine("5. Employee wages for a month");
                Console.WriteLine("6 Wages till a condition of total working hours or days is reached for a month");
                Console.WriteLine("7. Class Method to Compute Employee Wage");
                Console.WriteLine("8. Employee wage of multiple Companies");
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
                    case 4:
                        PartTimeUsingSwitch partTimeUsingSwitch = new PartTimeUsingSwitch();
                        partTimeUsingSwitch.ParttimeSwitch();
                        break;
                    case 5:
                        WagesForMonth wagesForMonth = new WagesForMonth();
                        wagesForMonth.WageMonth();
                        break;
                    case 6:
                        DayMonthCondition dayMonthCondition = new DayMonthCondition();
                        dayMonthCondition.Condition();
                        break;
                    case 7:
                        ClassMethodAndVars classMethodAndVars = new ClassMethodAndVars();
                        classMethodAndVars.EmpWage();
                        break;
                    case 8:
                        MultipleCompanies multipleCompanies = new MultipleCompanies();
                        multipleCompanies.Companies();
                        break;
                }
            }while(choice != 0);
        }
    }
}
