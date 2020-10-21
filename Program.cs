using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static int WAGE_PER_HR = 20;
        public static int PART_TIME = 2;
        public static int FULL_TIME = 1;
        static void Main(string[] args)
        {
            int salary, workingHr = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 3);
            if (empCheck == FULL_TIME)
            {
                Console.WriteLine("Full Time Employee");
                workingHr = 8;
            }
            else if(empCheck == PART_TIME)
            {
                Console.WriteLine("Part Time Employee");
                workingHr = 4;
            }
            else
            {
                Console.WriteLine("Employee is Absent");
            }
            salary = workingHr * WAGE_PER_HR;
            Console.WriteLine("Employee Wage: " + salary);
        }
    }
}
