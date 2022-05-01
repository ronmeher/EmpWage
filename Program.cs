using System;

namespace EmpWage
{
   
    internal class Program
    { 
    
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public const int WagePerHr = 100;
        public const int WorkDaysPerMonth = 20;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            
            int WorkingHr = 0;
            int Wage = 0;
            int TotalWage = 0;  

            

            for (int day = 1; day <= WorkDaysPerMonth; day++)
            {
                Random random = new Random();
                int EmpCheck = random.Next(3);

                switch (EmpCheck)
                {
                    case IsFullTime:
                    Console.WriteLine("Employee worked for Full-Time");
                    WorkingHr = 8;
                    break;

                    case IsPartTime:
                    Console.WriteLine("Employee worked for Part-Time");
                    WorkingHr = 4;
                    break;


                    default:
                    Console.WriteLine("Empoyee was Absent!");
                    break;
                }

                Wage = WorkingHr * WagePerHr;
                TotalWage += Wage;
                Console.WriteLine("Employee wage is " +TotalWage);
      
            }

              Console.WriteLine("The Employee Wage for a month is " +TotalWage);
        }
    }
}
