using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    public class CEO : Employee
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseAmount = 20.50M;

            Salary = baseAmount + (rank * 6);
        }

        public override void AssignManager(Employee manager)
        {
            throw new NotImplementedException("CEO cannot be assigned a manager");
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm doing a direct performance review");
        }

        public void FireSomeone()
        {
            Console.WriteLine("I'm firing someone");
        }
    }
}
