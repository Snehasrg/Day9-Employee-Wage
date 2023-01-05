namespace EmpWageDay9
{
    public class Program
    {
        public static void Main(string[] args) 
        {
          //Console.WriteLine("Welcome To Employee Wage Computation Program");
            MultipleComanyEW obj = new MultipleComanyEW();
            obj.Employee("Google", 20, 15, 80);
            Console.WriteLine("------------------------------------------------------");
            obj.Employee("Microsoft", 25, 10, 60);
        }
    }
}