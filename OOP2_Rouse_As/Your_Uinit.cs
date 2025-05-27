using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OOP2;

namespace OOP2_Rouse_As
{
    internal static class Your_Uinit
    {
        public static int TinhTuoi(this Employee emp)
        {
            return DateTime.Now.Year - emp.Brithday.Year + 1;
        }
    }
}
