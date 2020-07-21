using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class ExecutiveApplicant : IApplicant
    {
        public ExecutiveApplicant()
        {
            AccountsProcessor = new ExecutiveAccountsProcessor(this);
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public IAccountsProcessor AccountsProcessor { get; set; }
    }
}
