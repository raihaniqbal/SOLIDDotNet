using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class StaffAccountsProcessor : BaseAccountsProcessor, IAccountsProcessor
    {
        public StaffAccountsProcessor(IApplicant applicant) : base(applicant) { }
    }

    public class ExecutiveAccountsProcessor : BaseAccountsProcessor, IAccountsProcessor
    {
        public ExecutiveAccountsProcessor(IApplicant applicant) : base(applicant)
        {

        }

        public override Employee CreateEmployee()
        {
            var emp = base.CreateEmployee();
            emp.IsExecutive = true;

            return emp;
        }
    }

    public class ManagerAccountsProcessor : BaseAccountsProcessor, IAccountsProcessor
    {
        public ManagerAccountsProcessor(IApplicant applicant) : base(applicant)
        {
        }

        public override Employee CreateEmployee()
        {
            var emp = base.CreateEmployee();
            emp.IsExecutive = true;
            emp.IsManager = true;

            return emp;
        }
    }

    public interface IAccountsProcessor
    {
        Employee CreateEmployee();
    }

    public abstract class BaseAccountsProcessor : IAccountsProcessor
    {
        private const string _emailDomain = "acme.com";
        private IApplicant _applicant;
        public BaseAccountsProcessor(IApplicant applicant)
        {
            _applicant = applicant;
        }
        public virtual Employee CreateEmployee()
        {
            var newEmployee = new Employee
            {
                FirstName = _applicant.FirstName,
                LastName = _applicant.LastName,
                Email = String.Format("{0}{1}", _applicant.Email.Substring(0, _applicant.Email.IndexOf('@') + 1), _emailDomain)
            };

            return newEmployee;
        }
    }
}
