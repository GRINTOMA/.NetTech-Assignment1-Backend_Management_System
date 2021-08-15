using System;
using System.Collections.Generic;
using System.Text;

namespace MatthewGrinton_Assignment1
{
    public class Payroll
    {
        string date;
        int payrollID, employeeID, hoursWorked;
        double hourlyRate;

        public Payroll()
        {
            this.payrollID = 0;
            this.employeeID = 0;
            this.date = null;
            this.hoursWorked = 0;
            this.hourlyRate = 0;
        }
        public Payroll(int payrollID, int employeeID, string date, int hoursWorked, double hourlyRate)
        {
            this.payrollID = payrollID;
            this.employeeID = employeeID;
            this.date = date;
            this.hoursWorked = hoursWorked;
            this.hourlyRate = hourlyRate;
        }

        public int PayrollID 
        {
            get { return payrollID; }
            set { payrollID = value; }
        }
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; }
        }
        public string Date
        {
            get { return dateFormatter(date); }
            set { date = value; }
        }
        public string dateFormatter(string d)
        {
            return String.Format("{0:##/##/####}", Convert.ToUInt64(d));
        }
        public int HoursWorked
        {
            get { return hoursWorked; }
            set { hoursWorked = value; }
        }
        public string HourlyRate
        {
            get { return rateFormatter(hourlyRate); }
            set { hourlyRate = double.Parse(value); }
        }
        public string rateFormatter(double r)
        {
            return String.Format("{0:$##/hour}", r);
        }
        public override string ToString()
        {
            return $"{PayrollID,-10} {EmployeeID,-10} {Date,-10} {HoursWorked,-10} {HourlyRate,10}";
        }
    }
}
