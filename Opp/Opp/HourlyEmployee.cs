using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class HourlyEmployee :Employee
    {
        private long hourlyIncome { get; set; }

        public HourlyEmployee()
        {
        }

        public HourlyEmployee(long hourlyIncome)
        {
            this.hourlyIncome = hourlyIncome;
        }

        public HourlyEmployee( string name, int empID, long hourlyIncome) : base(name, empID)
        {
            this.hourlyIncome = hourlyIncome;
        }

        public long caculator_the_hourly_income()
        {
            return hourlyIncome * 150;
        }
    }
}
