using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class ClassMethodAndVars
    {
        const int IS_FULL_TIME = 2;
        const int IS_PART_TIME = 20;
        const int NUM_OF_WORKING_DAYS = 20;
        const int MAX_HRS_IN_MONTH = 100;

        int empHrs = 0;
        int totalEmpHrs = 0;
        int totalWorkingDays = 0;
        public void EmpWage()
        {
            while (totalEmpHrs < MAX_HRS_IN_MONTH && totalWorkingDays < NUM_OF_WORKING_DAYS)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case IS_FULL_TIME:
                        empHrs = 8;
                        break;
                    case IS_PART_TIME:
                        empHrs = 4;
                        break;
                    default:
                        empHrs = 0;
                        break;
                }
                totalEmpHrs += empHrs;
                Console.WriteLine("Day#:" + totalWorkingDays + " Emp Hrs : " + empHrs);
                if (totalEmpHrs == MAX_HRS_IN_MONTH)
                {
                    Console.WriteLine("Total working hours condition has reached i.e. " + MAX_HRS_IN_MONTH + " hrs");
                }
                if (totalWorkingDays == NUM_OF_WORKING_DAYS)
                {
                    Console.WriteLine("Total working days condition has reached i.e. " + NUM_OF_WORKING_DAYS + " days");
                }
            }
            int totalEmpWage = totalEmpHrs * NUM_OF_WORKING_DAYS;
            Console.WriteLine("Total Employee Wage : " + totalEmpWage);
        }
    }
}