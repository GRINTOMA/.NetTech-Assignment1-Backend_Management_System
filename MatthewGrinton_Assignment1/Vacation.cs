using System;
using System.Collections.Generic;
using System.Text;

namespace MatthewGrinton_Assignment1
{
    public class Vacation
    {
        int vacationID, employeeID, numOfDays;

        public Vacation(int vacationID, int employeeID, int numOfDays)
        {
            this.vacationID = vacationID;
            this.employeeID = employeeID;
            this.numOfDays = numOfDays;
        }

        public int VacationID {
            get { return vacationID; }
            set { vacationID = value; }
        }
        public int EmployeeID {
            get { return employeeID; } 
            set { employeeID = value; }
        }
        public int NumberOfDays { 
            get { return numOfDays; }
            set { numOfDays = value; }
        }

        public override string ToString()
        {
            return $"{VacationID, -10} {EmployeeID, -10} {NumberOfDays, 10}";
        }
    }
}
