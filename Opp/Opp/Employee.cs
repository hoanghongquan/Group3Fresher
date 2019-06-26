using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class Employee
    {
        public Employee()
        {

        }

        public Employee(string name, int empID)
        {
            this.Name = name;
            this.EmpID = empID;
        }

        private string name;
        private int empID;

        public string Name { get => name; set => name = value; }
        public int EmpID { get => empID; set => empID = value; }
    }
}
