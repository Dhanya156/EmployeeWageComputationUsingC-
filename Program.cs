using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static int WAGE_PER_HR = 20;
        public const int PART_TIME = 2;
        public const int FULL_TIME = 1;
        static void Main(string[] args)
        {
            int salary, workingHr = 0;
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
                    Console.WriteLine("Absent");
                    workingHr = 0;
                    break;
            }
            salary = workingHr * WAGE_PER_HR;
            Console.WriteLine("Employee Wage: " + salary);
        }
    }
}
