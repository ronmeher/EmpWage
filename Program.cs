using System;

namespace EmpWage
{
   
    internal class Program
    { 
        public class EmpWageBuilderObject
        {

            public const int IsFullTime = 1;
            public const int IsPartTime = 2;

            private string company;
            private int WagePerHr;
            private int WorkDaysPerMonth;
            private int MaxWorkHrPerMonth;
            private int EmpWage;

            public EmpWageBuilderObject(string company, int WagePerHr, int WorkDaysPerMonth, int MaxWorkHrPerMonth)
            { 
                this.company = company;
                this.WagePerHr = WagePerHr;
                this.WorkDaysPerMonth = WorkDaysPerMonth;
                this.MaxWorkHrPerMonth = MaxWorkHrPerMonth;
            }

            public void computeEmpWage()
            {

                int WorkingHr = 0;
                int TotalWorkingDays = 0;
                int TotalWorkingHr = 0;



                while (TotalWorkingHr <= this.MaxWorkHrPerMonth && TotalWorkingDays < this.WorkDaysPerMonth)
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

                int TotalWage = TotalWorkingHr * this.WagePerHr;
                Console.WriteLine("Total Employee Wage for the company: " +company + "is: " +TotalWage);
                


            }

            public string toString()
            {
                return "Total Employee Wage for the company: " +this.company + " is: " +this.EmpWage;
            }

        }



        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Employee Wage Computation Program!");

            EmpWageBuilderObject dmart = new EmpWageBuilderObject("DMart ", 4, 2, 10);
            EmpWageBuilderObject jio = new EmpWageBuilderObject("Jio ", 10, 4, 20);
            dmart.computeEmpWage();
            Console.WriteLine(dmart.toString());
            jio.computeEmpWage();
            Console.WriteLine(jio.ToString());


        }
        
    }
}
