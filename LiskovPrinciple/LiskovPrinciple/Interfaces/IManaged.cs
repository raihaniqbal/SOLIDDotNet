﻿using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple.Interfaces
{
    public interface IManaged : IEmployee
    {
        IEmployee Manager { get; set; }
        void AssignManager(IEmployee manager);
    }
}
