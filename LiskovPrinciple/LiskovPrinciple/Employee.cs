using LiskovPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    public abstract class EmployeeBase : IEmployee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }

        public virtual void CalculateSalary(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
    public class Employee : EmployeeBase, IManaged
    {
        public IEmployee Manager { get; set; }
        public void AssignManager(IEmployee manager)
        {
            Manager = manager;
        }
    }
}
