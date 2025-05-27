using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP1
{
    public class Employee
    {
        private int _id;
        private string _idCard;
        private string _name;
        private string _email;
        private string _phone;

        public Employee()
        {
            this._id = 0;
            _idCard = "";
            this._name = "";
            
        }

        public Employee(int _id,string _idCard, string _name, string _email, string _phone)
        {
            this._id = _id;
            this._idCard = _idCard;
            this._name = _name;
            this._email = _email;
            this._phone = _phone;
        }
        #region nhóm các thuộc tính(properties)
        public int ID
        {
            get { return _id; }
            set { _id = value; }
        }
        public string IDCard
        {
            get { return _idCard; }
            set { _idCard = value; }
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }
        public string Email
        { 
            get { return _email; }
            set { _email = value; }
        }
        public string Phone
        {
            get { return _phone; }
            set { _phone = value; }
        }
        #endregion
        #region nhóm các phương thức(methods)
        public void PrintInfor()
        {
            string msg = $"ID: {ID}\n" +
                         $"IDCard: {IDCard}\n" +
                         $"Name: {Name}\n" +
                         $"Email: {Email}\n" +
                         $"Phone: {Phone}";
            Console.WriteLine(msg);
        }
        public override string ToString()
        {
            string msg =   $"ID: {ID}\n" +
                           $"IDCard: {IDCard}\n" +
                           $"Name: {Name}\n" +
                           $"Email: {Email}\n" +
                           $"Phone: {Phone}";
            return msg;
        }
        #endregion

    }
}
