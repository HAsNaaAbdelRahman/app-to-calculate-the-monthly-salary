namespace app_to_calculate_monthly_salary
{
    public class Employee {
            protected const int MinimumLoggedHours = 176;
            public int Id { get; set; }
            public string Name {  get; set; }
            public decimal LoggedHours { get; set; }
            public decimal Wage { get; set; }

            public Employee(decimal wage, int id, string name, int loggedHours)
            {
                this.Wage = wage;
                this.Id = id;
                this.Name = name;
                this.LoggedHours = loggedHours;
            }


        protected decimal CalculatedadditionalHours() {

                var addtionalHours = LoggedHours - MinimumLoggedHours;

               return addtionalHours  ;

            }
        protected decimal BasicSalary() {
                return Wage *176;
            }


        protected virtual decimal OverTime(){
            return this.CalculatedadditionalHours()*Wage * 1.25m;

             }
            public override string ToString()
            {
            return $"\n ID : {Id} " + $"\n Name :{Name} " + $"\n LoggedHours: {LoggedHours} " + 
                $"\n Wage: {Wage} " + $"\n Basic Salary: {BasicSalary()} " + $"\n OverTime: {OverTime()}";
            }






    }
}
