using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    internal class Category
    {
        int id;
        string name;
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public void PrintInfor()
        {
            Console.WriteLine("ID: " + ID);
            Console.WriteLine("Name: " + Name);
        }


    }
}
