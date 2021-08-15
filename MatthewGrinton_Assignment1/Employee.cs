using System;
using System.Collections.Generic;
using System.Text;

namespace MatthewGrinton_Assignment1
{
    public class Employee
    {
        string name, address, email, phone, role;
        int ID;
        public Employee()
        {
            this.ID = 0;
            this.name = null;
            this.address = null;
            this.email = null;
            this.phone = null;
            this.role = null;
        }
        public Employee(int ID, string name, string address, string email,
            string phone, string role)
        {
            this.ID = ID;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }
        public int Id
        {
            get { return ID; }
            set { ID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email = value; }
        }
        public string Phone
        {
            get { return phoneFormater(phone); }
            set { phone = value; }
        }
        public string Role
        {
            get { return role; }
            set { role = value; }
        }
        public string phoneFormater(string p)
        {
            return String.Format("{0:(###) ###-####}", Convert.ToUInt64(p));
        }
        public override string ToString()
        {
            return $"{ID, -5} {Name, -15} {Address, -25} {Email, -20} {Phone, -10} {Role, 10}";
        }
    }
}
