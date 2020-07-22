using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple.Interfaces
{
    public interface IEmployee
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        decimal Salary { get; set; }
        void CalculateSalary(int rank);
    }
}
