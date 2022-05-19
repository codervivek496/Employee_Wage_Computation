namespace EmployeeWageComputation
{
    internal class CompanyEmpWage
    {
        private string company;
        private int empRatePerHour;
        private int numOfWorkingDays;
        private int maxHrsInMonth;

        public CompanyEmpWage(string company, int empRatePerHour, int numOfWorkingDays, int maxHrsInMonth)
        {
            this.company = company;
            this.empRatePerHour = empRatePerHour;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHrsInMonth = maxHrsInMonth;
        }

        internal void setTotalEmpWage(object v)
        {
            throw new NotImplementedException();
        }

        internal bool DisplayEmpWage()
        {
            throw new NotImplementedException();
        }

        internal void SetTotalEmpWage(int v)
        {
            throw new NotImplementedException();
        }
    }
}