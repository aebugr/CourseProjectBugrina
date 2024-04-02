using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectBugrina.Models
{
    public class Sales
    {
        public int IdSales { get; set; }
        public int IdEmpl { get; set; }
        public int IdGoods { get; set; }
        public DateTime DateAndTime { get; set; }
        public Sales() { }
        public Sales(int IdSales, int IdEmpl, int IdGoods, DateTime DateAndTime)
        {
            this.IdSales = IdSales;
            this.IdEmpl = IdEmpl;
            this.IdGoods = IdGoods;
            this.DateAndTime = DateAndTime;
        }
    }
}
