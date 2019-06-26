using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opp
{
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee employee = new HourlyEmployee("Hung 2K",1,10);
            Console.WriteLine("> Salary "+employee.Name+" : "+employee.caculator_the_hourly_income());

            PermanentEmployee permanentEmployee = new PermanentEmployee("Manh 2K",2,15);
            Console.WriteLine("> Salary " + permanentEmployee.Name+" : " + permanentEmployee.caculator_the_income());

            Console.ReadKey();
        }
    }
}
