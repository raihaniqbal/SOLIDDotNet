using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class ManagerApplicant : IApplicant
    {
        public ManagerApplicant()
        {
            AccountsProcessor = new ManagerAccountsProcessor(this);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IAccountsProcessor AccountsProcessor { get; set; }
    }
}
