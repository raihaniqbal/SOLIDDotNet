using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; protected set; }
        public Employee Manager { get; protected set; }
        public virtual void AssignManager(Employee manager)
        {
            Manager = manager;
        }
        public virtual void CalculateSalary(int rank)
        {
            decimal baseAmount = 12.50M;

            Salary = baseAmount + (rank * 2);
        }
    }
}
