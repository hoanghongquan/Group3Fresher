using System;

namespace bt1_oop
{
    public class Employee
    {
        public string name;
        public int empID;
        public string Name { get { return name; } set { name = value; } }
        public int EmpID { get { return empID; } set { empID = value; } }
    }
    public class HourlyEmployee : Employee
    {
        public double hourlyIncome;
        public HourlyEmployee(string Name, int EmpID, double HourlyIncome)
        {
            base.name = Name;
            base.empID = EmpID;
            this.hourlyIncome = HourlyIncome;
        }
        public void calculate_the_hourly_income()
        {
            double salary = hourlyIncome * 150;
            Console.WriteLine("Salary of Hourly Employee: " + salary);
        }
    }
    public class PermanentEmployee : Employee
    {
        public double hourlyIncome;
        public PermanentEmployee(string Name, int EmpID, double HourlyIncome)
        {
            base.name = Name;
            base.empID = EmpID;
            this.hourlyIncome = HourlyIncome;
        }
        public void calculate_the_hourly_income()
        {
            double salary = 240 * 150;
            Console.WriteLine("Salary of Permanent Employee: " + salary);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            HourlyEmployee he = new HourlyEmployee("Hoang hong quan", 300, 100);
            he.calculate_the_hourly_income();
            PermanentEmployee pe = new PermanentEmployee("Nam Anh", 2, 50);
            pe.calculate_the_hourly_income();
        }
    }
}
