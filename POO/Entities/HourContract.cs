using System;
using System.Collections.Generic;

namespace Course.Entities
{
     class HourContract
    {
        DateTime Date {  get; set; }
        public double ValuePerHour {  get; set; }
        public int Hours { get; set; }

        public double TotalValue()
        {
            return ValuePerHour * Hours;
        }

    }
}
