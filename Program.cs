using System;

namespace EmpWage
{
   
    internal class Program
    { 
    
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;
        public const int WagePerHr = 100;
        public const int WorkDaysPerMonth = 20;
        public const int MaxWorkHrPerMonth = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            
            int WorkingHr = 0;
            int TotalWorkingDays = 0;
            int TotalWorkingHr = 0;  

            

            while (TotalWorkingHr <= MaxWorkHrPerMonth && TotalWorkingDays < WorkDaysPerMonth)
            {
                TotalWorkingDays++;
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

                TotalWorkingHr += WorkingHr;
                Console.WriteLine("Days:" +TotalWorkingDays + " Hours:" +WorkingHr);
      
            }

            int TotalWage = TotalWorkingHr * WagePerHr;
            Console.WriteLine("Total Employee Wage:" + TotalWage);
        }
        
    }
}
