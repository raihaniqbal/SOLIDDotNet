using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Implementations
{
    public class Book : IBook, IBorrowableLibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
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
