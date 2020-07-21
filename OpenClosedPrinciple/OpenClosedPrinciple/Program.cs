using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<IApplicant> applicants = new List<IApplicant>();
            applicants.Add(new StaffApplicant { FirstName = "Raihan", LastName = "Iqbal", Email = "raihan.iqbal@gmail.com" });
            applicants.Add(new ExecutiveApplicant { FirstName = "Andrew", LastName = "Simmons", Email = "andrewsimmons@random.com" });
            applicants.Add(new ManagerApplicant { FirstName = "John", LastName = "Doe", Email = "john@random.com" });

            foreach (var applicant in applicants)
            {
                var employee = applicant.AccountsProcessor.CreateEmployee();
                Console.WriteLine(String.Format("First Name: {0}, Last Name: {1}, Email: {2}, Is Executive: {3}, Is Manager: {4}", employee.FirstName, employee.LastName, employee.Email, employee.IsExecutive, employee.IsManager));
            }
        }
    }
}
