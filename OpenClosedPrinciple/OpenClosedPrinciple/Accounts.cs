using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Accounts
    {
        private const string _emailDomain = "acme.com";
        public static Employee CreateEmployee(Applicant applicant)
        {
            var newEmployee = new Employee
            {
                FirstName = applicant.FirstName,
                LastName = applicant.LastName,
                Email = String.Format("{0}{1}", applicant.Email.Substring(0, applicant.Email.IndexOf('@') + 1), _emailDomain)
            };

            /*
             * This piece of code has broken the Open Closed Principle
             * since we have introduced new code that could potentially introduce
             * bugs in the existing code
             */
            if (applicant.TypeOfApplicant == ApplicantType.Manager)
                newEmployee.IsManager = true;

            return newEmployee;
        }
    }
}
