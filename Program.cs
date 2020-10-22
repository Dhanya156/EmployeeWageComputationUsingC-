using System;
using System.Runtime.CompilerServices;
using EmployeeWageComputation;


namespace EmployeeWageComputation
{
    public class EmpWageBuilderObject
    {
        public const int PART_TIME = 2;
        public const int FULL_TIME = 1;
        private string company;
        private int wagePerHr;
        private int numOfWorkingDays;
        private int maxHoursPerMonth;
        public int totalSalary = 0;

        public EmpWageBuilderObject(string company, int wagePerHr, int numOfWorkingDays, int maxHoursPerMonth)
        {
            this.company = company;
            this.wagePerHr = wagePerHr;
            this.numOfWorkingDays = numOfWorkingDays;
            this.maxHoursPerMonth = maxHoursPerMonth;
        }

        public void ComputeEmployeeWage()
        {
            int totalWorkingHr = 0, totalWorkingDays = 0;
            int totalSalary = 0, workingHr = 0;
            while (totalWorkingHr <= this.maxHoursPerMonth && totalWorkingDays <= this.numOfWorkingDays)
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
            }
            totalSalary = totalWorkingHr * this.wagePerHr;
            Console.WriteLine("The Employee Wage for a Company:" + company + " is " + totalSalary);

        }

        public string toString()
        {
            return "Total Employee Wage for Company:" + this.company + "is" + this.totalSalary;
        }
    }
}
class Program
{
    public static void Main(String[] args)
    {
        EmpWageBuilderObject happiestMind =new EmpWageBuilderObject("HappiestMind", 20, 10, 10);
        EmpWageBuilderObject Tcs =new EmpWageBuilderObject("Tcs", 20, 10, 10);
        happiestMind.ComputeEmployeeWage();
        Console.WriteLine(happiestMind.toString());
        Tcs.ComputeEmployeeWage();
        Console.WriteLine(Tcs.toString());

    }

}
