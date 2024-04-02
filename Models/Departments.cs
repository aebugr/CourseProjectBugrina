using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectBugrina.Models
{
    public class Departments
    {
        public int IdDepartamnets { get; set; }
        public string NameDepartaments { get; set; }
        public int NumberOfCounters { get; set; }
        public int HallNumber { get; set; }
        public Departments() { }
        public Departments(int IdDepartamnets, string NameDepartaments, int NumberOfCounters, int HallNumber)
        {
            this.IdDepartamnets = IdDepartamnets;
            this.NameDepartaments = NameDepartaments;
            this.NumberOfCounters = NumberOfCounters;
            this.HallNumber = HallNumber;
        }
    }
}
