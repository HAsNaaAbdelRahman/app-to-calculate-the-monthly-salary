namespace app_to_calculate_monthly_salary
{
    public class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager(10m , 1000 , "Ahmed A." , 176);

            Maintenance maintenance = new Maintenance(9m, 1001, "Salim M", 185);

            Sales sales = new Sales(8m, 1002, "Reem T.", 176, 10000.0m, 0.05m);

            Developer developer = new Developer(14m, 1003, "Raneem", 180 , false);

            Console.WriteLine("############ Welcome ############\n");

            Employee[] emp = { manager  , maintenance , sales , developer};

            foreach( Employee employee in emp )
            {
                Console.WriteLine(employee);
            }

        }
    }
}
