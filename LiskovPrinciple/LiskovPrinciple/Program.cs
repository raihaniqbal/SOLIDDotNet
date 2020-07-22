using LiskovPrinciple.Interfaces;
using System;

namespace LiskovPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IEmployee ceo = new CEO();
            ceo.FirstName = "Raihan";
            ceo.LastName = "Iqbal";
            ceo.CalculateSalary(10);

            IManaged manager = new Manager();
            manager.FirstName = "Emma";
            manager.LastName = "Stone";
            manager.CalculateSalary(5);
            manager.AssignManager(ceo);
            
            IManaged employee = new Employee();
            employee.FirstName = "John";
            employee.LastName = "Doe";
            employee.CalculateSalary(1);
            employee.AssignManager(manager);

            Console.WriteLine(String.Format("{0} {1} your hourly rate is: ${2}", employee.FirstName, employee.LastName, employee.Salary));
        }
    }
}
