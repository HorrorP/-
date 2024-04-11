using System;
using System.Collections.Generic;

namespace CarAccouting
{
    public partial class Employees
    {
        public int EmployeeId { get; set; }
        public string EmployeeUsername { get; set; }
        public string EmployeeFullName { get; set; }
        public string EmployeeJobTitle { get; set; }
        public string EmployeePhone { get; set; }
        public string EmployeePassHash { get; set; }
        public bool? IsAdmin { get; set; }
    }
}
