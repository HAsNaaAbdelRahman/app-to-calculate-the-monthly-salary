using System.Buffers.Text;

namespace app_to_calculate_monthly_salary
{
    class Developer : Employee
    {
        private  decimal BOUNS = 0.03m;
        private bool TaskCompleted = false;
        public Developer(decimal wage, int id, string name, int loggedHours , bool TaskCompleted ) : base(wage, id, name, loggedHours)
        {
            this.Wage = wage;
            this.Id = id;
            this.Name = name;
            this.LoggedHours = loggedHours;
            this.TaskCompleted = TaskCompleted;
        }

        private decimal CalculateBouns()
        {
            return(this.TaskCompleted == true?  this.BOUNS * base.BasicSalary() : 0);
        }
        protected decimal CalculateNetSalary()
        {
            return base.BasicSalary() + this.CalculateBouns();
        }

        public override string ToString()
        {
            return "Developer \n "+ base.ToString() + $"\n Task Completed :{this.TaskCompleted}" + $"\n Bouns :{this.CalculateBouns()}"+
                 $"\n Net Salary: {this.CalculateNetSalary()}\n";
        }

    }

        
}
