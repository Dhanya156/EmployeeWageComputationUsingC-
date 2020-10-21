using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static int WAGE_PER_HR = 20;
        public const int PART_TIME = 2;
        public const int FULL_TIME = 1;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        public const int MAX_WORKING_HRS = 100;
        static void Main(string[] args)
        {
            int salary, totalWorkingHr = 0, totalWorkingDays = 0;
            int totalSalary = 0, workingHr;
            while (totalWorkingHr < MAX_WORKING_HRS && totalWorkingDays < MAX_WORKING_HRS)
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
            }
            totalSalary = totalWorkingHr * WAGE_PER_HR;
            Console.WriteLine("totalWorkingHr" + totalWorkingHr);
            Console.WriteLine("totalSalary" + totalSalary);
        }
    }
}
