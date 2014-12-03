using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanStudentWorker
{
    class Worker : Human
    {
        private double weekSalary;
        private int hourPerDay;

        public Worker(string firstName, string lastName, double weekSalary, int hourPerDay)
            : base(firstName, lastName)
        {
            this.HoursPerDay = hourPerDay;
            this.WeekSalary = weekSalary;
        }
        public double WeekSalary
        {
            get
            {
                return this.weekSalary;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Salary can't be negative!!!");
                }
                this.weekSalary = value;
            }
        }
        public int HoursPerDay
        {
            get
            {
                return this.hourPerDay;
            }
            set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException("Hours can't be negative!!!");
                }
                this.hourPerDay = value;
            }
        }
        public double MoneyPerHour()
        {
            int dayOfWeek = 7;
            return this.WeekSalary / (dayOfWeek * this.HoursPerDay);
        }
    }
}
