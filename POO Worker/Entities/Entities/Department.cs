using System;
using System.Collections.Generic;

namespace Course.Entities
{
    class Department
    {
        public string DepartName { get; set; }

        public Department(string departName)
        {
            DepartName = departName;
        }
    }
}
