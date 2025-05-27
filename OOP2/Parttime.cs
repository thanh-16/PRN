using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Parttime: Employee
    {
        public int WorkHours { get; set; }
        public override double Salary()
        {
            return  WorkHours * 100;
        }
    }
}
