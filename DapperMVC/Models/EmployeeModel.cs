using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DapperMVC.Models
{
    public class EmployeeModel
    {
        public int EmployeeID { get; set; }

        public string Name { get; set; }
        public string Position { get; set; }
        public string Age { get; set; }
        public double Salary { get; set; }

    }
}