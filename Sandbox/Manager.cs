using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Win32.SafeHandles;

namespace Sandbox
{
    class Manager : Employee
    {
        private int _bonus;
        public int HoursWorked { get; set; }
        

        public int Bonus
        {
            get { return _bonus; }
            set { _bonus = value; }
        }

        public Manager(int bonus, string name, int salery) : base(name,salery)
        {
            this._bonus = bonus;
            this.HoursWorked = 0;
        }

        public bool IsBonusPaidOut()
        {
            if (HoursWorked >= 180)
            {
                return true;
            }
            return false;

        }

        public override int GetSalaryPerMonth()
        {
            if (IsBonusPaidOut())
            {
                return base.GetSalaryPerMonth() + Bonus; 
            }
            return base.GetSalaryPerMonth();
        }
    }
}
