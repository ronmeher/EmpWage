using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IsPresent = 1;
            int WorkingHr = 0;
            int WagePerHr = 100;
            int Wage = 0;

            Random random = new Random();

            int EmpCheck = random.Next(2);
         

            if (EmpCheck == IsPresent)
            {
                Console.WriteLine("Employee is Present!");
                WorkingHr = 8;

                
            }
            else
            {
                Console.WriteLine("Empoyee is Absent!");
                WorkingHr = 0;
            }

            Wage = WorkingHr * WagePerHr;
            Console.WriteLine("Employee Wage is " + Wage);
        }
    }
}
