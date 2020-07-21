using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public interface IApplicant
    {
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        IAccountsProcessor AccountsProcessor { get; set; }
    }

}
