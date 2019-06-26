using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bailab1
{

    class HourlyEmployee : Employee
    {
        private double hourlyIncome;
        public HourlyEmployee(string Name, int EmpID, double HourlyIncome)
        {
            this.Name = Name;
            this.EmpID = EmpID;
            this.hourlyIncome = HourlyIncome;
        }
        public void calculate_the_hourly_income()
        {
            double salary = hourlyIncome * 150;
            Console.WriteLine("Salary of hourly_employee: " + salary);
        }
    }
        class PermanentEmployee : Employee
        {
            private double hourlyIncome;
            public PermanentEmployee(string Name, int EmpID, double HourlyIncome)
            {
                this.Name = Name;
                this.EmpID = EmpID;
                hourlyIncome = HourlyIncome;
            }
        public void calculate_the_income()
        {
            double salary = 240 * 150;
            Console.WriteLine("Salary of permanentEmployee: " + salary);
        }
    }





        class Program
        {
            static void Main(string[] args)

        {
            
            HourlyEmployee fultime = new HourlyEmployee("Nguyễn Vân Anh", 2019, 120);
            fultime.calculate_the_hourly_income();
            PermanentEmployee partime = new PermanentEmployee("Đỗ Mỹ Linh", 1111, 50);
            partime.calculate_the_income();
            Console.ReadLine();
        }
        }
    }

              
            

