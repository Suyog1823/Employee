using System;
using System.Collections.Generic;

namespace Employee.Models
{
    public partial class EmployeeDetails
    {
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int WorkedYears { get; set; }
    }
}
