using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public const int PART_TIME = 2;
        public const int FULL_TIME = 1;
        
        public static void ComputeEmployeeWage(string company, int wagePerHr, int numOfWorkingDays, int maxHoursPerMonth)
        {
            int totalWorkingHr = 0, totalWorkingDays = 0;
            int totalSalary = 0, workingHr=0;
            while (totalWorkingHr < maxHoursPerMonth && totalWorkingDays < numOfWorkingDays)
            {
                totalWorkingDays++;
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        //Console.WriteLine("Full Time Employee");
                        workingHr = 8;
                        break;
                    case PART_TIME:
                        //Console.WriteLine("Part Time Employee");
                        workingHr = 4;
                        break;
                    default:
                        //Console.WriteLine("Employee is Absent");
                        workingHr = 0;
                        break;
                }
                totalWorkingHr = totalWorkingHr + workingHr;

                //Console.WriteLine("Days:" + totalWorkingDays + "  " + "EmployeeWorkingHrs:" + workingHr);
            
                totalSalary = totalWorkingHr * wagePerHr;
                Console.WriteLine( "The Employee Wage for a Company:" + company +" is " + totalSalary);
            }
      
        public static void Main(String[] args)
        {
            ComputeEmployeeWage("Tcs", 10, 20, 30);
            ComputeEmployeeWage("HappiestMind", 5, 15, 20);
        }
    }
}