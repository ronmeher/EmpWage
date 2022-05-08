using System;

namespace EmpWage
{
   
    internal class Program
    { 
    
        public const int IsFullTime = 1;
        public const int IsPartTime = 2;

        public static int computeEmpWage(string company, int WagePerHr, int WorkDaysPerMonth, int MaxWorkHrPerMonth)
        {
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
                Console.WriteLine("Days:" + TotalWorkingDays + " Hours:" + WorkingHr);


            }

            int TotalWage = TotalWorkingHr * WagePerHr;
            Console.WriteLine("Total Employee Wage:" + TotalWage);
            return TotalWage;




        }

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            
            computeEmpWage("D-Mart", 20, 2, 10);
            computeEmpWage("Jio", 22, 2, 12);

        }
        
    }
}
