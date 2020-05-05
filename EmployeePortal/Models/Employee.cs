using System;
using System.Collections.Generic;

namespace EmployeePortal.Models
{
    public partial class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int? Age { get; set; }
        public int? Salatry { get; set; }
    }
}
