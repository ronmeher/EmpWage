using System;

namespace EmpWage
{
   
    internal class Program
    { 
    
    public const int IsFullTime = 1;
    public const int IsPartTime = 2;
    public const int WagePerHr = 100;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");
            
<<<<<<< HEAD
            int WorkingHr = 0;
=======
            
            int WorkingHr = 0;
           
>>>>>>> UC4
            int Wage = 0;

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
                    WorkingHr = 0;
                    break;
            }

            Wage = WorkingHr * WagePerHr;
            Console.WriteLine("Employee Wage is " + Wage);
        }
    }
}
