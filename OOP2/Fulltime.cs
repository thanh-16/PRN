using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Fulltime : Employee
    {
        override public double Salary()
        {
            return base.Salary() + 5000;
        }
    }
}
