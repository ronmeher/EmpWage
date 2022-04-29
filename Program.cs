using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            
            int IsFullTime = 1;
            int IsPartTime = 2;
            int WorkingHr = 0;
            int WagePerHr = 100;
            int Wage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(3);


            if (EmpCheck == IsFullTime)
            {
                Console.WriteLine("Employee worked for Full-Time");
                WorkingHr = 8;


            }
            else if (EmpCheck == IsPartTime)
            {
                Console.WriteLine("Employee worked for Part-Time");
                WorkingHr = 4;
            }
            else
            {
                Console.WriteLine("Empoyee was Absent!");
                WorkingHr = 0;
            }

            Wage = WorkingHr * WagePerHr;
            Console.WriteLine("Employee Wage is " + Wage);
        }
    }
}
