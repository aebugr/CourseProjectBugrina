using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseProjectBugrina.Models
{
    public class Positions
    {
        public int IdPosition { get; set; }
        public string PositionName { get; set; }
        public int SumBet { get; set; }
        public Positions() { }
        public Positions(int IdPosition, string PositionName, int SumBet)
        {
            this.IdPosition = IdPosition;
            this.PositionName = PositionName;
            this.SumBet = SumBet;
        }
    }
}
