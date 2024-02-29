namespace app_to_calculate_monthly_salary
{
    public class Maintenance : Employee
    {
        private decimal HardShip = 100.0m;

        public Maintenance(decimal wage, int id, string name, int loggedHours) : base(wage, id, name, loggedHours)
        {
            this.Wage = wage;
            this.Id = id;
            this.Name = name;
            this.LoggedHours = loggedHours;
        }

        private decimal CalculateNetSalary()
        {
            return base.BasicSalary() + HardShip;
        }
        

        public override string ToString()
        {
            return "Maintenanace \n " + base.ToString() + $"\n Hardship :{HardShip} " + $"\n Net Salary {this.CalculateNetSalary()}\n";
        }


    }
}
