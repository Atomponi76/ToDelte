using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Worker
    {
        public string Surname { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public double SalaryDay { get; set; }
        public bool OfficialWork { get; set; }

        public double SalaryMonth
        {
            get
            {
                double msalary = (SalaryDay * 30);
                if (OfficialWork)
                {
                    return msalary - (msalary * 19.5 / 100);
                }
                else
                {
                    return msalary;
                }

            }
        }
        public bool IfPensioner {
            get
            {
                if (Age >= 60)
                {
                    return true;
                }
                else
                {
                    return false;
                }

            }

        }

        public Worker(){
        }
        public Worker(string surname, string name, int age, double salaryDay, bool officialWork)
        {
            Surname = surname;
            Name = name;
            Age = age;
            SalaryDay = salaryDay;
            OfficialWork = officialWork;
        }

        public override string ToString()
        {
            return $"{Name} {Surname} with age {Age}, daily salary:{SalaryDay},month salary:{SalaryMonth}. Offcial work: {OfficialWork}, Pensioner: {IfPensioner} ";
        }
    }
}
