using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Employee.Views.RequestController
{
    public class EmployeeDetailsRequest
    {
        public string EmployeeName { get; set; }
        public int Age { get; set; }
        public string Designation { get; set; }
        public int WorkedYears { get; set; }
    }
}
