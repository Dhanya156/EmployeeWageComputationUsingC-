using System;

namespace EmployeeWageComputation
{
    class Program
    {
        public static int WAGE_PER_HR = 20;
        static void Main(string[] args)
        {
            int IS_FULL_TIME = 1;
            int salary, workingHr = 0;
            Random random = new Random();
            int empCheck = random.Next(0, 2);
            if (empCheck == IS_FULL_TIME)
            {
                Console.WriteLine("Employee is Present");
                workingHr = 8;
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
