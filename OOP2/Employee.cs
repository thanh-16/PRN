using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2
{
    public class Employee
    {
        public int Id { get; set; }
        public string IdCard { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public DateTime Brithday { get; set; }
        public virtual double Salary (){
            return 4000;
        }
        public override string ToString()
        {
            return  "ID: " + Id + "\n" +
                    "IdCard: " + IdCard + "\n" +
                    "Name: " + Name + "\n" +
                    "Age: " + Age + "\n" +
                    "Brithday: " + Brithday.ToShortDateString() + "\n" +
                    "Salary: " + Salary() + "\n";



        }
    }
}
