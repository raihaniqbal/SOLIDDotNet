using InterfaceSegregationPrinciple.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Implementations
{
    public class ReferenceBook : ILibraryItem
    {
        public string LibraryId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Pages { get; set; }
        public DateTime? BorrowDate { get => throw new NotImplementedException("Cannot be borrowed"); set => throw new NotImplementedException("Cannot be borrowed"); }
        public string Borrower { get; set; }

        public void CheckIn() => throw new NotImplementedException("Cannot be borrowed");

        public void CheckOut(string borrower) => throw new NotImplementedException("Cannot be borrowed");
    }
}
