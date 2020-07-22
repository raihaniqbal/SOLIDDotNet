using System;
using System.Collections.Generic;
using System.Text;

namespace LiskovPrinciple.Interfaces
{
    public interface IManager : IEmployee
    {
        void GeneratePerformanceReview();
    }
}
