using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeWageComputation
{
    internal class EmpWageBuilderObject
    {
        public const int IS_PART_TIME = 1;
        public const int IS_FULL_TIME = 2;

        //Using instance variables instead of parameters as per Use Case requirements
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        private int totalEmpWage;

        //Constructor
        public EmpWageBuilderObject(string company, int empRatePerHour, int numOfWorkingDays, int maxHoursPerMonth)
        {
            //Setting value in class from constructor
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }
        public void computeEmpWage()
        {
            //variables
            int empHrs = 0, totalEmpHrs = 0, totalWorkingDays = 0;
            //Computation
            while (totalEmpHrs <= this.maxHoursPerMonth && totalWorkingDays < this.numOfWorkingDays)
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
                totalEmpHrs = +empHrs;
                Console.WriteLine("Days#: " + totalWorkingDays + " Emp Hrs: " + empHrs);

                if (totalEmpHrs == this.maxHoursPerMonth)
                {
                    Console.WriteLine("Total working hours condition has reached i.e " + this.maxHoursPerMonth + " hrs");
                }
                if (totalWorkingDays == this.numOfWorkingDays)
                {
                    Console.WriteLine("Total Working days condition has reached i.e " + this.numOfWorkingDays + " days");
                }
            }
            totalEmpWage = totalEmpHrs * this.empRatePerHour;
            //Console.WriteLine("Total Emp Wage for company: " + company + " is: " + totalEmpWage);
        }

        //Displaying wage by each company
        public string DisplayEmpWage()
        {
            return "Total emp Wage for company : " + this.company + " : is " + this.totalEmpWage;
        }
    }
    internal class SaveTotalWages
    {
        public void SaveWage()
        {
            //Passing valur to parameters of constructor
            EmpWageBuilderObject accenture = new EmpWageBuilderObject("Acceture", 20, 15, 10);
            EmpWageBuilderObject deloitte = new EmpWageBuilderObject("Deloitte", 22, 13, 25);

            //calculating wage for each employee
            accenture.computeEmpWage();

            //Diplaying total wage of employees
            Console.WriteLine(accenture.DisplayEmpWage());

            deloitte.computeEmpWage();
            Console.WriteLine(deloitte.DisplayEmpWage());
        }
    }
}