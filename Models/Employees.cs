using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectBugrina.Models
{
    public class Employees
    {
        public int IdEmployees { get; set; }
        public string EmployeesFIO { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime WorkDate { get; set; }
        public int IdDepart { get; set; }
        public int IdPosit { get; set; }
        public string Address { get; set; }

        public Employees() { }

        public Employees(int IdEmployees, string EmployeesFIO, DateTime BirthDate, DateTime WorkDate, 
            int IdDepart, int IdPosit, string Address)
        {
            this.IdEmployees = IdEmployees;
            this.EmployeesFIO = EmployeesFIO;
            this.BirthDate = BirthDate;
            this.WorkDate = WorkDate;
            this.IdDepart = IdDepart;
            this.IdPosit = IdPosit;
            this.Address = Address;
        }
    }
}
