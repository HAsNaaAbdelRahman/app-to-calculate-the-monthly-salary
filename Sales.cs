namespace app_to_calculate_monthly_salary
{
    public class Sales : Employee
    { 
        private  decimal comission ;
        private decimal sales ;

        public Sales(decimal wage, int id, string name, int loggedHours , decimal sales ,decimal comission) : base(wage, id, name, loggedHours)
        {
            this.Wage = wage;
            this.Id = id;
            this.Name = name;
            this.LoggedHours = loggedHours;
            this.sales = sales;
            this.comission = comission;
        }
        
        private decimal CalculateBouns()
        {
            return comission * this.sales ;
        }
        protected decimal CalculateNetSalary()
        {
            return base.BasicSalary() + this.CalculateBouns();
        }

        public override string ToString()
        {
            return "Sales \n " + base.ToString() + $"\n Bouns :{this.CalculateBouns()} "+
                $"\n Comission {this.comission}"+
                $"\n Net Salary: {this.CalculateNetSalary()}\n"  ;
        }
    }
    
}
