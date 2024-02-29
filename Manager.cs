using System;

namespace app_to_calculate_monthly_salary
{
    public class Manager : Employee
    {

        private const decimal allowance = 0.05m;

        public Manager(decimal wage, int id, string name, int loggedHours) : base(wage, id, name, loggedHours)
        {
            this.Wage = wage;
            this.Id = id;
            this.Name = name;
            this.LoggedHours = loggedHours;
        }


        protected override decimal OverTime()
        {
            return base.OverTime();
        }

        private decimal CalculateAllowance()
        {
            return allowance * base.BasicSalary();
        }

        public override string ToString()
        {
            return "Managers \n " + base.ToString() + $"\n Allowance {CalculateAllowance()} " + 
                $"\n Net Salary {base.BasicSalary() + this.CalculateAllowance()}\n" ;
        }
    }
}
