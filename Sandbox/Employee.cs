using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Employee
    {
        public String name;
        public int salaryPerMonth;

        public Employee(String name, int salaryPerMonth)
        {
            this.name = name;
            this.salaryPerMonth = salaryPerMonth;
        }

        public Employee()
        {
            
        }

        public String GetName()
        {
            return name;
        }

        public virtual int GetSalaryPerMonth()
        {
            return salaryPerMonth;
        }
    }
}
