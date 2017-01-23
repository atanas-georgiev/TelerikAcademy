using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem02StudentsAndWorkers
{
    class Worker : Human
    {
        public double WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }
        public Worker() { }
        public Worker(double weekSalary, int workHoursPerDay)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public Worker(string firstName, string lastName, double weekSalary, int workHoursPerDay)
            : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        public double MoneyPerHour()
        {
            return WeekSalary / 5 / WorkHoursPerDay;
        }

        public override string ToString()
        {
            return String.Format("Name: {0} {1}, Week Salary = {2}, Work hours per day: {3}", base.FirstName, base.LastName, WeekSalary, WorkHoursPerDay);
        }
    }
}
