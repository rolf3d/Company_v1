using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox
{
    class Worker : Employee
    {
        private string _skill;


        public Worker(string skill, string name, int salary) : base(name, salary)
        {
            this._skill = skill;
        }

        public void SetSkill(string skill)
        {
            this._skill = skill;
        }

        public string GetSkill()
        {
            return _skill;
        }

        
    }
}
