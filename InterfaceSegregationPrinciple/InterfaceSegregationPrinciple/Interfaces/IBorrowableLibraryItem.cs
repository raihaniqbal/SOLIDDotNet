using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface IBorrowableLibraryItem : ILibraryItem
    {
        DateTime? BorrowDate { get; set; }
        string Borrower { get; set; }
        void CheckIn();
        void CheckOut(string borrower);
    }
}
