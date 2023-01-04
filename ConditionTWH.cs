namespace EmpWageDay9
{
    public class ConditionTWH
    {
        public void Check()
        {
            int Wage_Per_Hour = 20;
            int Max_Days_IN_Month = 20;
            int Max_HrsInMonth = 100;
            int empHour;
            int totalHours = 0;
            int totalDays = 0;
            ;
            while (totalHours < Max_HrsInMonth || totalDays < Max_Days_IN_Month)
            {
                Random R = new Random();
                int empCheck = R.Next(3);
                totalDays++;
                switch (empCheck)
                {
                    case 1:
                        {
                            //Console.WriteLine("Employee is present.");
                            empHour = 8;
                            break;
                        }
                    case 2:
                        {
                            //Console.WriteLine("Employee present PartTime.");
                            empHour = 4;
                            break;
                        }
                    default:
                        {
                            //Console.WriteLine("Employee is absent.");
                            empHour = 0;
                            break;
                        }
                }
                totalHours = (totalHours + empHour);


                Console.WriteLine("Total employee hours are :- " + totalHours);
                int sallery = totalHours * Wage_Per_Hour;
                Console.WriteLine("Total employee wage is :- " + sallery);
                Console.WriteLine("\n");
            }
        }
    }
}
