﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul9.home
{
    public class Manager : Employee
    {
        public decimal Bonus { get; set; }

        public Manager(string name, int age, decimal salary, decimal bonus)
            : base(name, age, salary)
        {
            Bonus = bonus;
        }

        public override decimal CalculateAnnualSalary()
        {
            return base.CalculateAnnualSalary() + Bonus;
        }
    }

}
