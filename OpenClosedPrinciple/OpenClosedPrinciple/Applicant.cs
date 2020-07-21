using System;
using System.Collections.Generic;
using System.Text;

namespace OpenClosedPrinciple
{
    public class Applicant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public ApplicantType TypeOfApplicant { get; set; } = ApplicantType.Staff;

    }

    public enum ApplicantType
    {
        Staff,
        Manager
    }
}
