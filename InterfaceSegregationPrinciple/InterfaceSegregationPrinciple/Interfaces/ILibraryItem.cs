﻿using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceSegregationPrinciple.Interfaces
{
    public interface ILibraryItem
    {
        string LibraryId { get; set; }
        string Title { get; set; }

    }
}
