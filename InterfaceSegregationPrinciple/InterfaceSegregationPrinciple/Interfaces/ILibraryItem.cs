using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }
        string Author { get; set; }
        int Pages { get; set; }
        DateTime? BorrowDate { get; set; }
        string Borrower { get; set; }
        void CheckIn();
        void CheckOut(string borrower);

    }
}
