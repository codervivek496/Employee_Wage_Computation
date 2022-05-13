using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class PartTimeUsingSwitch
    {
        public void ParttimeSwitch()
        {
            //constants
            const int IS_PART_TIME = 1;
            const int IS_FULL_TIME = 2;
            const int EMP_RATE_PERHOUR = 20;
            //variables
            int empHrs = 0;
            int empWage = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);

            switch (empCheck)
            {
                case IS_FULL_TIME:
                    Console.WriteLine("Employee is Full Time");
                    empHrs = 8;
                    break;
                case IS_PART_TIME:
                    Console.WriteLine("Employee is Part time");
                    empHrs = 4;
                    break;
                default:
                Console.WriteLine("Employee is absent");
                empHrs = 0;
                    break;
            }
            empWage = empHrs * EMP_RATE_PERHOUR;
            Console.WriteLine("Emp  Wage : " + empWage);
        }
    }
}