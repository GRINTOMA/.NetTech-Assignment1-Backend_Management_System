using System;
using System.Collections.Generic;
using System.Text;

namespace MatthewGrinton_Assignment1
{
    public class Employee
    {
        string ID, name, address, email, phone, role;

        private Employee(string ID, string name, string address, string email,
            string phone, string role)
        {
            this.ID = ID;
            this.name = name;
            this.address = address;
            this.email = email;
            this.phone = phone;
            this.role = role;
        }
        public string getID()
        {
            return this.ID;
        }
        public string getName()
        {
            return this.name;
        }
        public string getAddress()
        {
            return this.address;
        }
        public string getEmail()
        {
            return this.email;
        }
        public string getPhone()
        {
            return this.phone;
        }
        public string getRole()
        {
            return this.role;
        }

        public void setID(string newID)
        {
            this.ID = newID;
        }
        public void setName(string newName)
        {
            this.name = newName;
        }
        public void setAddress(string newAddress)
        {
            this.address = newAddress;
        }
        public void setEmail(string newEmail)
        {
            this.email = newEmail;
        }
        public void setPhone(string newPhone)
        {
            this.phone = newPhone;
        }
        public void setRole(string newRole)
        {
            this.role = newRole;
        }
    }
}

