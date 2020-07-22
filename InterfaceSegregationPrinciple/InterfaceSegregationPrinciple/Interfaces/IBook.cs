using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface IBook : ILibraryItem
    {
        string Author { get; set; }
        int Pages { get; set; }
    }
}
