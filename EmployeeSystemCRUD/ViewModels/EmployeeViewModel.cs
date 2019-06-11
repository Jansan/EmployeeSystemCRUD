using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmployeeSystemCRUD.ViewModels
{
    public class EmployeeViewModel
    {
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public string Office { get; set; }
        public int Age { get; set; }
        public decimal Salary { get; set; }
    }
}