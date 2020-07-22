using LiskovPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    public class Manager : Employee, IManager
    {
        public override void CalculateSalary(int rank)
        {
            decimal baseAmount = 14.50M;

            Salary = baseAmount + (rank * 4);
        }

        public void GeneratePerformanceReview()
        {
            Console.WriteLine("I'm doing a performance review for someone I manage");
        }
    }
}
