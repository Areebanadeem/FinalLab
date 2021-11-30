using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final
{
    public abstract class Employee
    {
        public int EmployeeID;
        public string EmployeeName;
        public string EmployeeType;
        public double HourWorked;
        public double NoOfUnitProduced;
        public double BaseHours = 160;
        public double hourlyPayRate= 2.00;
        public double OverTimeRate= 1.00;
        double unitPay;
         public abstract void calcSalary();
    }
}