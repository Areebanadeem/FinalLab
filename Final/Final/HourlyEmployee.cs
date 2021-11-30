using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Final
{
    public class HourlyEmployee : Employee
    {
        public override void calcSalary()
        {
            if (HourWorked >= BaseHours)
            {
                double basePay = hourlyPayRate * BaseHours;
                double overTimeHour = HourWorked - BaseHours;
                double overTimePay = hourlyPayRate * overTimeHour * OverTimeRate;
                double unitPay;

                if (NoOfUnitProduced > 0 || NoOfUnitProduced < 100)
                {
                    unitPay = 3.000 * NoOfUnitProduced;

                }
                else if (NoOfUnitProduced > 101 || NoOfUnitProduced < 200)
                {
                    unitPay = 3.250 * NoOfUnitProduced;

                }
                else if (NoOfUnitProduced > 201 || NoOfUnitProduced < 300)
                {
                    unitPay = 3.500 * NoOfUnitProduced;

                }
                else
                {
                    unitPay = 4.000 * NoOfUnitProduced;

                }
                double GrossPay = basePay + overTimePay + unitPay;
            }
        }
    }
}