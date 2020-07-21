using System;

namespace LiskovPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Manager manager = new Manager();
            manager.FirstName = "Emma";
            manager.LastName = "Stone";
            manager.CalculateSalary(5);
            
            Employee employee = new Employee();
            employee.FirstName = "John";
            employee.LastName = "Doe";
            employee.CalculateSalary(1);
            employee.AssignManager(manager);

            Console.WriteLine(String.Format("{0} {1} your hourly rate is: ${2}", employee.FirstName, employee.LastName, employee.Salary));

            /**
             * The following code breaks the Liskov Principle since I am not able to replace and instance of Employee with 
             * an instance of it's sub-type CEO. 
             */
            //Employee ceo = new CEO();
            //ceo.FirstName = "Raihan";
            //ceo.LastName = "Iqbal";
            //ceo.CalculateSalary(10);
            //ceo.AssignManager(manager); // this will throw an exception
        }
    }
}
