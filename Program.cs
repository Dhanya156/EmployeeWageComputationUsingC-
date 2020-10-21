using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static int WAGE_PER_HR = 20;
        public const int PART_TIME = 2;
        public const int FULL_TIME = 1;
        public const int NUMBER_OF_WORKING_DAYS = 20;
        static void Main(string[] args)
        {
            int salary, workingHr = 0;
            int totalSalary = 0;
            for (int day = 0; day < NUMBER_OF_WORKING_DAYS; day++)
            {
                Random random = new Random();
                int empCheck = random.Next(0, 3);
                switch (empCheck)
                {
                    case FULL_TIME:
                        Console.WriteLine("Full Time Employee");
                        workingHr = 8;
                        break;
                    case PART_TIME:
                        Console.WriteLine("Part Time Employee");
                        workingHr = 4;
                        break;
                    default:
                        Console.WriteLine("Employee is Absent");
                        workingHr = 0;
                        break;
                }
                salary = workingHr * WAGE_PER_HR;
                totalSalary += salary;
                Console.WriteLine("Employee Wage: " + salary);
            }
            Console.WriteLine("The total salary is " +totalSalary);
        }
    }
}
