namespace EmpWageDay9
{
    public class Program
    {
        public static void Main(string[] args) 
        {
            TotalWage obj = new TotalWage("Google", 20, 10, 50);
            TotalWage obj1 = new TotalWage("Microsoft", 20, 10, 50);

            obj.ComputeEmpWage();
            Console.WriteLine(obj.Return());
            obj1.ComputeEmpWage();
            Console.WriteLine(obj1.Return());
        }
    }
}