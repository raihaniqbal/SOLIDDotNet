using System;
using System.Collections.Generic;

namespace OpenClosedPrinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Applicant> applicants = new List<Applicant>();
            applicants.Add(new Applicant { FirstName = "Raihan", LastName = "Iqbal", Email = "raihan.iqbal@gmail.com" });
            applicants.Add(new Applicant { FirstName = "John", LastName = "Doe", Email = "john@random.com", TypeOfApplicant = ApplicantType.Manager });

            foreach(var applicant in applicants)
            {
                var employee = Accounts.CreateEmployee(applicant);
                Console.WriteLine(String.Format("First Name: {0}, Last Name: {1}, Email: {2}, Is Manager: {3}", employee.FirstName, employee.LastName, employee.Email, employee.IsManager));
            }
        }
    }
}
