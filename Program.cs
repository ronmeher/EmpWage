using System;

namespace EmpWage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int IsPresent = 1;

            Random random = new Random();

            int EmpCheck = random.Next(2);

            if (EmpCheck == IsPresent)
            {
                Console.WriteLine("Employee is Present!");
            }
            else
            {
                Console.WriteLine("Empoyee is Absent!");
            }
        }
    }
}
