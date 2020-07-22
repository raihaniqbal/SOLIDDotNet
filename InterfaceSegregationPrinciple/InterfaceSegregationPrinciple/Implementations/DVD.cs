using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Implementations
{
    public class DVD : IBorrowableLibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Director { get; set; }
        public int RuntimeInMinutes { get; set; }
        public DateTime? BorrowDate { get; set; }
        public string Borrower { get; set; }

        public void CheckIn()
        {
            Borrower = "";
            BorrowDate = null;
        }

        public void CheckOut(string borrower)
        {
            Borrower = borrower;
            BorrowDate = DateTime.Today;
        }
    }
}
