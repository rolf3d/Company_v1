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

        public void SetWorker(string skill)
        {
            this._skill = skill;
        }

        public string GetWorker()
        {
            return _skill;
        }


    }
}
