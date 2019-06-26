using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class PermanentEmployee:Employee
    {
        public PermanentEmployee()
        {
        }

        public PermanentEmployee(long hourlyIncome)
        {
            this.hourlyIncome = hourlyIncome;
        }

        public PermanentEmployee( string name, int empID, long hourlyIncome) : base(name, empID)
        {
            this.hourlyIncome = hourlyIncome;
        }

        private long hourlyIncome { get; set; }

        public long caculator_the_income()
        {
            return 240 * 150;
        }
    }
}
